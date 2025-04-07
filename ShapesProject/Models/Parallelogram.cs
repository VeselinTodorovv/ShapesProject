
using System.Drawing.Drawing2D;

namespace ShapesProject.Models;

class Parallelogram : Shape
{
    public int Base { get; protected set; }
    public int Height { get; protected set; }
    public int Side { get; protected set; }

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

    public override double CalculateArea() => Base * Height;

    public override void Draw(Graphics g)
    {
        var pos = GetDrawingPosition();
        using Pen pen = new(BorderColor);
        using SolidBrush brush = new(FillColor);

        Point[] points =
        {
            new(pos.X, pos.Y),
            new(pos.X + Base, pos.Y),
            new(pos.X + Base - Side, pos.Y - Height),
            new(pos.X - Side, pos.Y - Height)
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
            new(pos.X - SelectionBorderWidth, pos.Y + SelectionBorderWidth),
            new(pos.X + Base + SelectionBorderWidth, pos.Y + SelectionBorderWidth),
            new(pos.X + Base - Side + SelectionBorderWidth, pos.Y - Height - SelectionBorderWidth),
            new(pos.X - Side - SelectionBorderWidth, pos.Y - Height - SelectionBorderWidth)
        };
    
        g.DrawPolygon(selectionPen, selectionPoints);
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

    public override bool Contains(Point p)
    {
        return p.X >= X - Side && p.X <= X + Base &&
               p.Y >= Y - Height && p.Y <= Y;
    }
}