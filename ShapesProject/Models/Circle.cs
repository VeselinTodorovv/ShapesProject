
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
        var pos = GetDrawingPosition();
        int diameter = 2 * Radius;

        using Pen pen = new(BorderColor);
        using SolidBrush brush = new(FillColor);

        g.FillEllipse(brush, pos.X - Radius, pos.Y - Radius, diameter, diameter);
        g.DrawEllipse(pen, pos.X - Radius, pos.Y - Radius, diameter, diameter);

        if (!IsSelected)
        {
            return;
        }
        
        using var selectionPen = new Pen(Color.Red, SelectionBorderWidth);
        selectionPen.DashStyle = DashStyle.Dash;
        
        g.DrawEllipse(selectionPen, pos.X - Radius - SelectionBorderWidth, pos.Y - Radius - SelectionBorderWidth, 
        diameter + 2 * SelectionBorderWidth, diameter + 2 * SelectionBorderWidth);
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
        var pos = GetDrawingPosition();
        double distance = Math.Sqrt(Math.Pow(p.X - pos.X, 2) + Math.Pow(p.Y - pos.Y, 2));

        return distance <= Radius;
    }
}