using System.Drawing.Drawing2D;

namespace ShapesProject.Models;

public class Trapezoid : Shape
{
    public int Base1 { get; protected set; }
    public int Base2 { get; protected set; }
    public int Height { get; protected set; }

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

    public override double CalculateArea() => (Base1 + Base2) * Height / 2.0;

    public override void Draw(Graphics g)
    {
        var pos = GetDrawingPosition();
        using Pen pen = new(BorderColor);
        using SolidBrush brush = new(FillColor);
        
        Point[] points =
        {
            new(pos.X, pos.Y),  // Top-left corner
            new(pos.X + Base1, pos.Y),  // Top-right corner
            new(pos.X + Base1 - Base2 + (Base1 - Base2) / 2, pos.Y + Height),  // Bottom-right corner
            new(pos.X + (Base1 - Base2) / 2, pos.Y + Height)  // Bottom-left corner
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
            new(pos.X - SelectionBorderWidth, pos.Y - SelectionBorderWidth),
            new(pos.X + Base1 + SelectionBorderWidth, pos.Y - SelectionBorderWidth),
            new(pos.X + Base1 - Base2 + (Base1 - Base2) / 2 + SelectionBorderWidth, pos.Y + Height + SelectionBorderWidth),
            new(pos.X + (Base1 - Base2) / 2 - SelectionBorderWidth, pos.Y + Height + SelectionBorderWidth)
        };
        
        g.DrawPolygon(selectionPen, selectionPoints);
    }

    public override bool Contains(Point p)
    {
        return p.X >= X && p.X <= X + Math.Max(Base1, Base2) &&
               p.Y >= Y && p.Y <= Y + Height;
    }
}