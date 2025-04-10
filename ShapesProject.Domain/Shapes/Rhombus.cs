using ShapesProject.Domain.Primitives;

namespace ShapesProject.Domain.Shapes;

public class Rhombus : Shape
{
    public int Diagonal1 { get; private set; }
    public int Diagonal2 { get; private set; }

    public Rhombus(int x, int y, int diagonal1, int diagonal2) : base(x, y)
    {
        if (diagonal1 <= 0 || diagonal2 <= 0)
        {
            throw new ArgumentException("Diagonals must be positive");
        }

        Diagonal1 = diagonal1;
        Diagonal2 = diagonal2;
    }

    public override void EditSize(params int[] parameters)
    {
        if (parameters.Length == 2 &&
            parameters[0] > 0 && parameters[1] > 0)
        {
            Diagonal1 = parameters[0];
            Diagonal2 = parameters[1];
        }
        else
        {
            throw new ArgumentException("Invalid parameters");
        }
    }
    public override double CalculateArea() => Diagonal1 * Diagonal2 / 2.0;
    public override void Accept(IRenderVisitor visitor)
    {
        visitor.VisitRhombus(this);
    }

    public override bool Contains(CustomPoint p)
    {
        return p.X >= X - Diagonal2 / 2 && p.X <= X + Diagonal2 / 2 &&
               p.Y >= Y - Diagonal1 / 2 && p.Y <= Y + Diagonal1 / 2;
    }
    
    public override Shape Clone()
    {
        var clone = new Rhombus(X, Y, Diagonal1, Diagonal2)
        {
            FillColor = FillColor,
            BorderColor = BorderColor,
            IsSelected = IsSelected,
            TempOffsetX = TempOffsetX,
            TempOffsetY = TempOffsetY,
        };
        
        return clone;
    }

}