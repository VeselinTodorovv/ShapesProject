using ShapesProject.Domain.Primitives;

namespace ShapesProject.Domain.Shapes;

public class Parallelogram : Shape
{
    public int Base { get; set; }
    public int Height { get; set; }
    public int Side { get; set; }

    public Parallelogram(int x, int y, int baseLength, int height, int side) : base(x, y)
    {
        if (baseLength <= 0 || height <= 0 || side <= 0)
        {
            throw new ArgumentException("Base, height, and side length must be positive.");
        }

        Base = baseLength;
        Height = height;
        Side = side;
    }

    public override void EditSize(params int[] parameters)
    {
        if (parameters.Length == 3 && parameters[0] > 0 && parameters[1] > 0 && parameters[2] > 0)
        {
            Base = parameters[0];
            Height = parameters[1];
            Side = parameters[2];
        }
        else
        {
            throw new ArgumentException("Invalid parameters for parallelogram. Provide base, height, and side length.");
        }
    }
    public override double CalculateArea() => Base * Height;

    public override void Accept(IRenderVisitor visitor)
    {
        visitor.VisitParallelogram(this);
    }

    public override bool Contains(CustomPoint p)
    {
        return p.X >= X - Side && p.X <= X + Base &&
               p.Y >= Y - Height && p.Y <= Y;
    }
    
    public override Shape Clone()
    {
        var clone = new Parallelogram(X, Y, Base, Height, Side)
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