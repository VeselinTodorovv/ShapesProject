using ShapesProject.Domain.Primitives;

namespace ShapesProject.Domain.Shapes;

public abstract class Shape
{
    protected int X { get; set; }

    protected int Y { get; set; }

    public int TempOffsetX { get; set; }

    public int TempOffsetY { get; set; }

    public CustomColor FillColor { get; set; } = CustomColor.White;

    public CustomColor BorderColor { get; set; } = CustomColor.Black;

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

    public virtual int SelectionBorderWidth => 2;
    
    public abstract Shape Clone();
}