using System.Drawing.Drawing2D;

namespace ShapesProject.Models;

public class Rhombus : Shape
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
        var pos = GetDrawingPosition();
        using Pen pen = new(BorderColor);
        using SolidBrush brush = new(FillColor);
        
        Point[] points =
        {
            new(pos.X, pos.Y - Diagonal1 / 2),
            new(pos.X + Diagonal2 / 2, pos.Y),
            new(pos.X, pos.Y + Diagonal1 / 2),
            new(pos.X - Diagonal2 / 2, pos.Y)
        };
        
        g.FillPolygon(brush, points);
        g.DrawPolygon(pen, points);
        
        if (!IsSelected)
        {
            return;
        }
        
        using var selectionPen = new Pen(Color.Red, SelectionBorderWidth);
        selectionPen.DashStyle = DashStyle.Dash;
        
        // Offset selection border
        Point[] selectionPoints =
        {
            new(pos.X, pos.Y - Diagonal1 / 2 - SelectionBorderWidth),
            new(pos.X + Diagonal2 / 2 + SelectionBorderWidth, pos.Y),
            new(pos.X, pos.Y + Diagonal1 / 2 + SelectionBorderWidth),
            new(pos.X - Diagonal2 / 2 - SelectionBorderWidth, pos.Y)
        };
        
        g.DrawPolygon(selectionPen, selectionPoints);
    }

    public override bool Contains(Point p)
    {
        return p.X >= X - Diagonal2 / 2 && p.X <= X + Diagonal2 / 2 &&
               p.Y >= Y - Diagonal1 / 2 && p.Y <= Y + Diagonal1 / 2;
    }
}