using ShapesProject.Utils.Commands.Core;

namespace ShapesProject.Models;

public abstract class Shape
{
    public int X { get; protected set; }

    public int Y { get; protected set; }

    public int TempOffsetX { get; internal set; }

    public int TempOffsetY { get; internal set; }

    public Color FillColor { get; set; } = Color.White;

    public Color BorderColor { get; set; } = Color.Black;

    public bool IsSelected { get; internal set; }

    protected Shape(int x, int y)
    {
        X = x;
        Y = y;
    }

    public abstract void EditSize(params int[] parameters);
    
    protected Point GetDrawingPosition() => new(X + TempOffsetX, Y + TempOffsetY);

    public abstract double CalculateArea();

    public abstract void Draw(Graphics g);

    public virtual void Move(int x, int y)
    {
        X += x;
        Y += y;
    }

    public abstract bool Contains(Point p);

    protected virtual int SelectionBorderWidth => 2;
    
    public abstract Shape Clone();
    public abstract ICommand CreateEditCommand(Shape oldShape);
}