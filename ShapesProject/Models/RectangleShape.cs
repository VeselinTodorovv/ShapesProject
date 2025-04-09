using System.Drawing.Drawing2D;
using ShapesProject.Utils.Commands.Core;

namespace ShapesProject.Models;

public class RectangleShape : Shape
{
    public int Width { get; set; }

    public int Height { get; set; }

    public RectangleShape(int x, int y, int width, int height) : base(x, y)
    {
        if (width <= 0 || height <= 0)
            throw new ArgumentException("Width and Height must be positive.");

        Width = width;
        Height = height;
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

    public override bool Contains(Point p)
    {
        var pos = GetDrawingPosition();

        return p.X >= pos.X && p.X <= pos.X + Width &&
               p.Y >= pos.Y && p.Y <= pos.Y + Height;
    }
    public override Shape Clone() => throw new NotImplementedException();
    public override ICommand CreateEditCommand(Shape oldCircle) => throw new NotImplementedException();
}