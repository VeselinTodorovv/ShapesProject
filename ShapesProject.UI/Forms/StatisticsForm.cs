using ShapesProject.Domain.Shapes;

namespace ShapesProject.Forms;

public partial class StatisticsForm : Form
{
    private readonly IEnumerable<Shape> _shapes;
    
    private const double MinAreaThreshold = 100d;
    private const double LargeAreaThreshold = 1000d;
    private const int TopLargestShapesCount = 3;
    
    public StatisticsForm(IEnumerable<Shape> shapes)
    {
        InitializeComponent();
        
        _shapes = shapes;
    }
    
    private void StatisticsForm_Load(object sender, EventArgs e)
    {
        LoadOverviewTab();

        LoadTopThreeLargest();
        LoadAverageAreaByType();
        LoadAllAboveMinAreaTypes();
        LoadMostCommonType();
    }

    private void LoadOverviewTab()
    {
        var statisticsByType = _shapes
            .GroupBy(s => s.GetType().Name)
            .Select(group => new
            {
                ShapeType = group.Key,
                Count = group.Count(),
                TotalArea = Math.Round(group.Sum(shape => shape.CalculateArea()), 2)
            })
            .ToList();
        
        dataGridViewStatistics.DataSource = statisticsByType;
        
        int totalCount = statisticsByType.Sum(g => g.Count);
        double totalArea = statisticsByType.Sum(g => g.TotalArea);

        labelTotalCount.Text = @$"Total Count: {totalCount}";
        labelTotalArea.Text = @$"Total Area: {totalArea:F2}";
    }

    private void LoadTopThreeLargest()
    {
        var topThreeLargest = _shapes
            .Select(s => new { Type = s.GetType().Name, Area = s.CalculateArea() })
            .OrderByDescending(s => s.Area)
            .Take(TopLargestShapesCount)
            .ToList();

        listBoxTopThreeLargest.Items.Clear();
        
        foreach (var item in topThreeLargest)
        {
            listBoxTopThreeLargest.Items.Add(FormatTypeArea(item.Type, item.Area));
        }
    }

    private void LoadAverageAreaByType()
    {
        var avgByType = _shapes
            .Where(s => s.CalculateArea() > LargeAreaThreshold)
            .GroupBy(s => s.GetType().Name)
            .Select(group => new
            {
                Type = group.Key,
                AverageArea = Math.Round(group.Average(s => s.CalculateArea()), 2)
            })
            .OrderByDescending(x => x.AverageArea)
            .ToList();
        
        listBoxAvgByType.Items.Clear();
        
        foreach (var item in avgByType)
        {
            listBoxAvgByType.Items.Add(FormatTypeArea(item.Type, item.AverageArea));
        }
    }

    private void LoadAllAboveMinAreaTypes()
    {
        var allAboveMin = _shapes
            .GroupBy(s => s.GetType().Name)
            .Where(g => g.All(s => s.CalculateArea() > MinAreaThreshold))
            .Select(g => g.Key)
            .ToList();
        
        listBoxAllAboveMin.Items.Clear();

        foreach (var type in allAboveMin)
        {
            listBoxAllAboveMin.Items.Add(type);
        }
    }

    private void LoadMostCommonType()
    {
        var groups = _shapes
            .GroupBy(s => s.GetType().Name)
            .Select(g => new
            {
                Type = g.Key,
                Count = g.Count()
            })
            .ToList();

        if (groups.Count == 0)
        {
            labelMostCommonType.Text = @"None";
        }

        int max = groups.Max(g => g.Count);

        var mostCommonTypes = groups
            .Where(g => g.Count == max)
            .Select(g => g.Type)
            .ToList();

        labelMostCommonType.AutoSize = true;
        labelMostCommonType.Text = string.Join(", ", mostCommonTypes);
    }

    private static string FormatTypeArea(string type, double area) => $"{type}: {area:F2}";
}