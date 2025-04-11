using System.ComponentModel;
using ShapesProject.Domain.Primitives;

namespace ShapesProject.Domain.Shapes;

public abstract class Shape
{
    protected int X { get; protected private set; }

    protected int Y { get; protected private set; }

    // TODO: Think of a way to remove this dependency while still hiding from property grid
    [Browsable(false)]
    public int TempOffsetX { get; set; }

    [Browsable(false)]
    public int TempOffsetY { get; set; }

    public CustomColor FillColor { get; set; } = CustomColor.White;

    public CustomColor BorderColor { get; set; } = CustomColor.Black;

    [Browsable(false)]
    public bool IsSelected { get; set; }

    protected Shape(int x, int y)
    {
        X = x;
        Y = y;
    }

    public abstract void EditSize(params int[] parameters);
    
    public CustomPoint GetDrawingPosition() => new(X + TempOffsetX, Y + TempOffsetY);

    public abstract double CalculateArea();

    public abstract void Accept(IRenderVisitor visitor);

    public virtual void Move(int x, int y)
    {
        X += x;
        Y += y;
    }

    public abstract bool Contains(CustomPoint p);

    [Browsable(false)]
    public virtual int SelectionBorderWidth => 2;
    
    public abstract Shape Clone();
}