namespace ShapesProject.Models;

public abstract class Shape
{
    public int X { get; protected set; }

    public int Y { get; protected set; }

    public Color FillColor { get; set; } = Color.White;

    public Color BorderColor { get; set; } = Color.Black;

    protected Shape(int x, int y)
    {
        X = x;
        Y = y;
    }

    public abstract double CalculateArea();

    public abstract void Draw(Graphics g);

    public virtual void Move(int x, int y)
    {
        X += x;
        Y += y;
    }

    public abstract void EditSize(params int[] parameters);

    public abstract bool Contains(Point p);
}