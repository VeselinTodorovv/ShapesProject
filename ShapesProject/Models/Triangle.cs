using System.Drawing.Drawing2D;
using ShapesProject.Utils.Commands.Core;
using ShapesProject.Utils.Commands.Edit;

namespace ShapesProject.Models;

public class Triangle : Shape
{
    public Point Point1 { get; set; }
    public Point Point2 { get; set; }
    public Point Point3 { get; set; }

    public Triangle(Point point1, Point point2, Point point3) : base(point1.X, point1.Y)
    {
        Point1 = point1;
        Point2 = point2;
        Point3 = point3;
    }

    public override void EditSize(params int[] parameters)
    {
        if (parameters.Length == 6)
        {
            Point1 = new Point(parameters[0], parameters[1]);
            Point2 = new Point(parameters[2], parameters[3]);
            Point3 = new Point(parameters[4], parameters[5]);
 
            X = Point1.X;
            Y = Point1.Y;
        }
        else
        {
            throw new ArgumentException("Invalid parameters for triangle.");
        }
    }
    public override double CalculateArea()
    {
        return Math.Abs((Point1.X * (Point2.Y - Point3.Y) +
                         Point2.X * (Point3.Y - Point1.Y) +
                         Point3.X * (Point1.Y - Point2.Y)) / 2.0);
    }

    public override void Draw(Graphics g)
    {
        using Pen pen = new(BorderColor);
        using SolidBrush brush = new(FillColor);
        
        // Temporary offset
        Point[] points = 
        {
            new(Point1.X + TempOffsetX, Point1.Y + TempOffsetY),
            new(Point2.X + TempOffsetX, Point2.Y + TempOffsetY),
            new(Point3.X + TempOffsetX, Point3.Y + TempOffsetY)
        };
        
        g.FillPolygon(brush, points);
        g.DrawPolygon(pen, points);
        
        if (!IsSelected)
        {
            return;
        }
        
        using var selectionPen = new Pen(Color.Red, SelectionBorderWidth);
        selectionPen.DashStyle = DashStyle.Dash;
        
        // Offset selection border
        Point[] selectionPoints =
        {
            new(points[0].X - SelectionBorderWidth, points[0].Y - SelectionBorderWidth),
            new(points[1].X + SelectionBorderWidth, points[1].Y - SelectionBorderWidth),
            new(points[2].X, points[2].Y + SelectionBorderWidth)
        };
        
        g.DrawPolygon(selectionPen, selectionPoints);
    }

    public override void Move(int x, int y)
    {
        Point1 = new Point(Point1.X + x, Point1.Y + y);
        Point2 = new Point(Point2.X + x, Point2.Y + y);
        Point3 = new Point(Point3.X + x, Point3.Y + y);

        X = Point1.X;
        Y = Point1.Y;
    }

    public override bool Contains(Point p)
    {
        double area = CalculateArea();
        double area1 = Math.Abs((Point1.X * (Point2.Y - p.Y) +
                                  Point2.X * (p.Y - Point1.Y) +
                                  p.X * (Point1.Y - Point2.Y)) / 2.0);
        double area2 = Math.Abs((Point2.X * (Point3.Y - p.Y) +
                                  Point3.X * (p.Y - Point2.Y) +
                                  p.X * (Point2.Y - Point3.Y)) / 2.0);
        double area3 = Math.Abs((Point3.X * (Point1.Y - p.Y) +
                                  Point1.X * (p.Y - Point3.Y) +
                                  p.X * (Point3.Y - Point1.Y)) / 2.0);
        
        const double tolerance = 0.01;
        return Math.Abs(area - (area1 + area2 + area3)) < tolerance;
    }
    
    public override Shape Clone()
    {
        var clone = new Triangle(Point1, Point2, Point3)
        {
            FillColor = FillColor,
            BorderColor = BorderColor,
            IsSelected = IsSelected,
            TempOffsetX = TempOffsetX,
            TempOffsetY = TempOffsetY
        };

        return clone;
    }
    
    public override ICommand CreateEditCommand(Shape oldShape)
    {
        if (oldShape is not Triangle triangle)
        {
            throw new ArgumentException("Invalid shape.");
        }
        
        // TODO: Implement
        return new EditTriangleCommand();
    }
}