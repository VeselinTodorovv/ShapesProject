using ShapesProject.Domain.Shapes;

namespace ShapesProject.Forms;

public partial class StatisticsForm : Form
{
    private readonly IEnumerable<Shape> _shapes;
    
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
    }
}