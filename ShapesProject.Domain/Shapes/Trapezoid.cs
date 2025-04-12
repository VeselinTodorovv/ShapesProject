using ShapesProject.Domain.Primitives;

namespace ShapesProject.Domain.Shapes;

public class Trapezoid : Shape
{
    public int Base1 { get; set; }
    public int Base2 { get; set; }
    public int Height { get; set; }

    public Trapezoid(int x, int y, int base1, int base2, int height) : base(x, y)
    {
        if (base1 <= 0 || base2 <= 0 || height <= 0)
        {
            throw new ArgumentException("Base lengths and height must be positive.");
        }

        Base1 = base1;
        Base2 = base2;
        Height = height;
    }

    public override void EditSize(params int[] parameters)
    {
        if (parameters.Length == 3 && parameters[0] > 0 && parameters[1] > 0 && parameters[2] > 0)
        {
            Base1 = parameters[0];
            Base2 = parameters[1];
            Height = parameters[2];
        }
        else
        {
            throw new ArgumentException("Values must be positive.");
        }
    }
    public override double CalculateArea() => (Base1 + Base2) * Height / 2.0;

    public override void Accept(IRenderVisitor visitor)
    {
        visitor.VisitTrapezoid(this);
    }

    public override bool Contains(CustomPoint p)
    {
        return p.X >= X && p.X <= X + Math.Max(Base1, Base2) &&
               p.Y >= Y && p.Y <= Y + Height;
    }

    public override Shape Clone()
    {
        var clone = new Trapezoid(X, Y, Base1, Base2, Height)
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