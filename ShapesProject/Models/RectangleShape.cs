using ShapesProject.Models.Primitives;
using ShapesProject.Utils.Commands.Core;
using ShapesProject.Utils.Commands.Edit;

namespace ShapesProject.Models;

public class RectangleShape : Shape
{
    public int Width { get; set; }

    public int Height { get; set; }

    public RectangleShape(int x, int y, int width, int height) : base(x, y)
    {
        if (width <= 0 || height <= 0)
            throw new ArgumentException("Width and Height must be positive.");

        Width = width;
        Height = height;
    }

    public override void EditSize(params int[] parameters)
    {
        if (parameters.Length == 2 && parameters[0] > 0 && parameters[1] > 0)
        {
            Width = parameters[0];
            Height = parameters[1];
        }
        else
        {
            throw new ArgumentException("Width and Height must be positive.");
        }
    }
    public override double CalculateArea() => Width * Height;
    public override void Accept(IRenderVisitor visitor)
    {
        visitor.VisitRectangle(this);
    }

    public override bool Contains(CustomPoint p)
    {
        var pos = GetDrawingPosition();

        return p.X >= pos.X && p.X <= pos.X + Width &&
               p.Y >= pos.Y && p.Y <= pos.Y + Height;
    }
    
    public override Shape Clone()
    {
        var clone = new RectangleShape(X, Y, Width, Height)
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
        if (oldShape is not RectangleShape rectangle)
        {
            throw new ArgumentException("Invalid shape type.");
        }
        
        return new EditRectangleCommand(
            this,
            rectangle.Width, this.Width,
            rectangle.Height, this.Height,
            rectangle.FillColor, this.FillColor,
            rectangle.BorderColor, this.BorderColor
        );
    }
}