﻿using ShapesProject.Domain.Primitives;
using ShapesProject.Domain.Rendering;

namespace ShapesProject.Domain.Shapes;

[Serializable]
public class Circle : Shape
{
    public int Radius { get; set; }

    public Circle(int x, int y, int radius) : base(x, y)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("Radius must be positive.");
        }

        Radius = radius;
    }

    public override void EditSize(params int[] parameters)
    {
        if (parameters.Length == 1 && parameters[0] > 0)
        {
            Radius = parameters[0];
        }
        else
        {
            throw new ArgumentException("Radius must be positive .");
        }
    }
    
    public override string? Validate()
    {
        return Radius <= 0
            ? "Radius must be positive."
            : null;
    }
    
    public override double CalculateArea() => Math.PI * Radius * Radius;

    public override void Accept(IRenderVisitor visitor)
    {
        visitor.VisitCircle(this);
    }

    public override bool Contains(CustomPoint p)
    {
        var pos = GetDrawingPosition();
        double distance = Math.Sqrt(Math.Pow(p.X - pos.X, 2) + Math.Pow(p.Y - pos.Y, 2));

        return distance <= Radius;
    }
    
    public override Shape Clone()
    {
        var clone = new Circle(X, Y, Radius)
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