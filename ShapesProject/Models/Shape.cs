using ShapesProject.Models.Primitives;
using ShapesProject.Utils.Commands.Core;

namespace ShapesProject.Models;

public abstract class Shape
{
    public int X { get; protected set; }

    public int Y { get; protected set; }

    public int TempOffsetX { get; protected set; }

    public int TempOffsetY { get; protected set; }

    public CustomColor FillColor { get; set; } = CustomColor.White;

    public CustomColor BorderColor { get; set; } = CustomColor.Black;

    public bool IsSelected { get; internal set; }

    protected Shape(int x, int y)
    {
        X = x;
        Y = y;
    }

    public abstract void EditSize(params int[] parameters);
    
    protected internal Point GetDrawingPosition() => new(X + TempOffsetX, Y + TempOffsetY);

    public abstract double CalculateArea();

    public abstract void Accept(IRenderVisitor visitor);

    public virtual void Move(int x, int y)
    {
        X += x;
        Y += y;
    }

    public abstract bool Contains(CustomPoint p);

    protected internal virtual int SelectionBorderWidth => 2;
    
    public abstract Shape Clone();
    public abstract ICommand CreateEditCommand(Shape oldShape);
}