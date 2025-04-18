using ShapesProject.Domain.Shapes;

namespace ShapesProject.Forms;

public partial class StatisticsForm : Form
{
    private readonly IEnumerable<Shape> _shapes;
    
    private List<object> _topThreeLargest;
    private List<object> _avgByType;
    private List<string> _allAboveMin;
    private string _mostCommonType;
    
    public StatisticsForm(IEnumerable<Shape> shapes)
    {
        InitializeComponent();
        
        _shapes = shapes;
    }
    
    private void StatisticsForm_Load(object sender, EventArgs e)
    {
        LoadStatistics();
    }

    private void LoadStatistics()
    {
        var groupedStats = _shapes.GroupBy(s => s.GetType().Name)
            .Select(group => new
            {
                ShapeType = group.Key,
                Count = group.Count(),
                TotalArea = Math.Round(group.Sum(shape => shape.CalculateArea()), 2)
            })
            .ToList();
        
        dataGridViewStatistics.DataSource = groupedStats;
        
        int totalCount = groupedStats.Sum(g => g.Count);
        double totalArea = groupedStats.Sum(g => g.TotalArea);

        labelTotalCount.Text = @$"Total Count: {totalCount}";
        labelTotalArea.Text = @$"Total Area: {totalArea:f2}";


        //1
        _topThreeLargest = _shapes
            .Select(s => new
            {
                Type = s.GetType().Name,
                Area = s.CalculateArea()
            })
            .OrderByDescending(s => s.Area)
            .Take(3)
            .ToList<object>();
        
        //2
        _avgByType = _shapes
            .Where(s => s.CalculateArea() > 1000)
            .GroupBy(s => s.GetType().Name)
            .Select(group => new
            {
                Type = group.Key,
                AverageArea = Math.Round(group.Average(s => s.CalculateArea()), 2)
            })
            .OrderByDescending(x => x.AverageArea)
            .ToList<object>();
        
        
        //3
        const double minArea = 5.0;
        _allAboveMin = _shapes
            .GroupBy(s => s.GetType().Name)
            .Where(g => g.All(s => s.CalculateArea() > minArea))
            .Select(s => s.GetType().Name)
            .ToList();
        
        //4
        _mostCommonType = _shapes
            .GroupBy(s => s.GetType().Name)
            .OrderByDescending(g => g.Count())
            .Select(s => s.Key)
            .FirstOrDefault()
            ?? "None";
    }
}