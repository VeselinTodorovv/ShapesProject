﻿using ShapesProject.Domain.Primitives;
using ShapesProject.Domain.Rendering;

namespace ShapesProject.Domain.Shapes;

[Serializable]
public class Triangle : Shape
{
    public CustomPoint Point1 { get; set; }
    public CustomPoint Point2 { get; set; }
    public CustomPoint Point3 { get; set; }

    public Triangle(CustomPoint point1, CustomPoint point2, CustomPoint point3) : base(point1.X, point1.Y)
    {
        Point1 = point1;
        Point2 = point2;
        Point3 = point3;
    }

    public override void EditSize(params int[] parameters)
    {
        if (parameters.Length == 6)
        {
            Point1 = new CustomPoint(parameters[0], parameters[1]);
            Point2 = new CustomPoint(parameters[2], parameters[3]);
            Point3 = new CustomPoint(parameters[4], parameters[5]);
 
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

    public override void Accept(IRenderVisitor visitor)
    {
        visitor.VisitTriangle(this);
    }

    public override void Move(int x, int y)
    {
        Point1 = new CustomPoint(Point1.X + x, Point1.Y + y);
        Point2 = new CustomPoint(Point2.X + x, Point2.Y + y);
        Point3 = new CustomPoint(Point3.X + x, Point3.Y + y);

        X = Point1.X;
        Y = Point1.Y;
    }

    public override bool Contains(CustomPoint p)
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
        var clone = new Triangle(
            new CustomPoint(Point1.X, Point1.Y),
            new CustomPoint(Point2.X, Point2.Y),
            new CustomPoint(Point3.X, Point3.Y))
        {
            FillColor = FillColor,
            BorderColor = BorderColor,
            IsSelected = IsSelected,
            TempOffsetX = TempOffsetX,
            TempOffsetY = TempOffsetY
        };

        return clone;
    }
}