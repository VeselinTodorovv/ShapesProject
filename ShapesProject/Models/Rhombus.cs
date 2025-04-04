using System.Drawing.Drawing2D;

namespace ShapesProject.Models;

class Rhombus : Shape
{
    public int Diagonal1 { get; protected set; }
    public int Diagonal2 { get; protected set; }

    public Rhombus(int x, int y, int diagonal1, int diagonal2) : base(x, y)
    {
        if (diagonal1 <= 0 || diagonal2 <= 0)
        {
            throw new ArgumentException("Diagonals must be positive");
        }

        Diagonal1 = diagonal1;
        Diagonal2 = diagonal2;
    }

    public override double CalculateArea() => Diagonal1 * Diagonal2 / 2.0;

    public override void Draw(Graphics g)
    {
        using Pen pen = new(BorderColor);
        using SolidBrush brush = new(FillColor);

        Point[] points =
        {
            new(X, Y - Diagonal1 / 2),
            new(X + Diagonal2 / 2, Y),
            new(X, Y + Diagonal1 / 2),
            new(X - Diagonal2 / 2, Y)
        };

        g.FillPolygon(brush, points);
        g.DrawPolygon(pen, points);

        if (IsSelected)
        {
            using var selectionPen = new Pen(Color.Red, SelectionBorderWidth) { DashStyle = DashStyle.Dash };
            g.DrawPolygon(selectionPen, points);
        }
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

    public override bool Contains(Point p)
    {
        // Check if the point is within the bounding rectangle of the rhombus
        return p.X >= X - Diagonal2 / 2 && p.X <= X + Diagonal2 / 2 &&
               p.Y >= Y - Diagonal1 / 2 && p.Y <= Y + Diagonal1 / 2;
    }
}