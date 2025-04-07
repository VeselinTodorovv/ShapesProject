using System.Drawing.Drawing2D;

namespace ShapesProject.Models;

public class RectangleShape : Shape
{
    public int Width { get; protected set; }

    public int Height { get; protected set; }

    public RectangleShape(int x, int y, int width, int height) : base(x, y)
    {
        if (width <= 0 || height <= 0)
            throw new ArgumentException("Width and Height must be positive.");

        Width = width;
        Height = height;
    }

    public override double CalculateArea() => Width * Height;

    public override void Draw(Graphics g)
    {
        var pos = GetDrawingPosition();
        using Pen pen = new(BorderColor);
        using SolidBrush brush = new(FillColor);

        g.FillRectangle(brush, pos.X, pos.Y, Width, Height);
        g.DrawRectangle(pen, pos.X, pos.Y, Width, Height);

        if (!IsSelected)
        {
            return;
        }
        
        using var selectionPen = new Pen(Color.Red, SelectionBorderWidth);
        selectionPen.DashStyle = DashStyle.Dash;

        var rect = new Rectangle(pos.X - SelectionBorderWidth, pos.Y - SelectionBorderWidth,
        Width + 2 * SelectionBorderWidth,
        Height + 2 * SelectionBorderWidth
        );

        g.DrawRectangle(selectionPen, rect);
    }

    public override void EditSize(params int[] parameters)
    {
        if (parameters.Length == 2 && parameters[0] > 0 && parameters[1] > 0)
        {
            Width = parameters[0];
            Height = parameters[1];
        }
        else
        {
            throw new ArgumentException("Width and Height must be positive.");
        }
    }

    public override bool Contains(Point p)
    {
        return p.X >= X && p.X <= X + Width && p.Y >= Y && p.Y <= Y + Height;
    }
}