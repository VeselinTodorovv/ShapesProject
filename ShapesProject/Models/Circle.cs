
using System.Drawing.Drawing2D;

namespace ShapesProject.Models;

public class Circle : Shape
{
    public int Radius { get; protected set; }

    public Circle(int x, int y, int radius) : base(x, y)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("Radius must be positive.");
        }

        Radius = radius;
    }

    public override double CalculateArea() => Math.PI * Radius * Radius;

    public override void Draw(Graphics g)
    {
        using Pen pen = new(BorderColor);
        using SolidBrush brush = new(FillColor);
        int diameter = 2 * Radius;

        g.FillEllipse(brush, X - Radius, Y - Radius, diameter, diameter);
        g.DrawEllipse(pen, X - Radius, Y - Radius, diameter, diameter);

        if (IsSelected)
        {
            using var selectionPen = new Pen(Color.Red, SelectionBorderWidth);
            selectionPen.DashStyle = DashStyle.Dash;

            g.DrawEllipse(selectionPen, X - Radius - SelectionBorderWidth, Y - Radius - SelectionBorderWidth,
                          diameter + 2 * SelectionBorderWidth, diameter + 2 * SelectionBorderWidth);
        }
    }

    public override void EditSize(params int[] parameters)
    {
        if (parameters.Length == 1 && parameters[0] > 0)
        {
            Radius = parameters[0];
        }
        else
        {
            throw new ArgumentException("Radius must be positive .");
        }
    }

    public override bool Contains(Point p)
    {
        double distance = Math.Sqrt(Math.Pow(p.X - X, 2) + Math.Pow(p.Y - Y, 2));
        return distance <= Radius;
    }
}