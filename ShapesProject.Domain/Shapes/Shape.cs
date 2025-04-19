using ShapesProject.Domain.Primitives;
using ShapesProject.Domain.Rendering;

namespace ShapesProject.Domain.Shapes;

[Serializable]
public abstract class Shape : ICloneable
{
    public int X { get; protected set; }

    public int Y { get; protected set; }

    protected int TempOffsetX { get; set; }

    protected int TempOffsetY { get; set; }

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

    public void ModifyTempOffset(int x, int y)
    {
        TempOffsetX = x;
        TempOffsetY = y;
    }

    public virtual string? Validate() => null;

    public abstract double CalculateArea();

    public abstract void Accept(IRenderVisitor visitor);

    public virtual void Move(int x, int y)
    {
        X += x;
        Y += y;
    }

    public abstract bool Contains(CustomPoint p);

    public virtual int SelectionBorderWidth => 2;
    
    public abstract object Clone();
}