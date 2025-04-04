using System.Drawing.Drawing2D;

namespace ShapesProject.Models;

public class Triangle : Shape
{
    public Point Point1 { get; protected set; }
    public Point Point2 { get; protected set; }
    public Point Point3 { get; protected set; }

    public Triangle(Point point1, Point point2, Point point3) : base(point1.X, point1.Y)
    {
        Point1 = point1;
        Point2 = point2;
        Point3 = point3;
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
        Point[] points = { Point1, Point2, Point3 };

        g.FillPolygon(brush, points);
        g.DrawPolygon(pen, points);

        if (IsSelected)
        {
            using var selectionPen = new Pen(Color.Red, SelectionBorderWidth);
            selectionPen.DashStyle = DashStyle.Dash;
            
            g.DrawPolygon(selectionPen, points);
        }
    }

    public override void Move(int x, int y)
    {
        Point1 = new Point(Point1.X + x, Point1.Y + y);
        Point2 = new Point(Point2.X + x, Point2.Y + y);
        Point3 = new Point(Point3.X + x, Point3.Y + y);

        X = Point1.X;
        Y = Point1.Y;
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
}