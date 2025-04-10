using ShapesProject.Models.Primitives;
using ShapesProject.Utils.Commands.Core;
using ShapesProject.Utils.Commands.Edit;

namespace ShapesProject.Models;

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
    
    public override ICommand CreateEditCommand(Shape oldShape)
    {
        if (oldShape is not Circle circle)
        {
            throw new ArgumentException("Invalid shape type.");
        }
        
        return new EditCircleCommand(
            this,
            circle.Radius, this.Radius,
            circle.FillColor, this.FillColor,
            circle.BorderColor, this.BorderColor
        );
    }
}