using System.Drawing;
using System.Drawing.Drawing2D;
using ShapesProject.Domain;
using ShapesProject.Domain.Primitives;

namespace ShapesProject.Forms.Renderers;

public class GraphicsRenderer : IRenderVisitor
{
    private readonly Graphics _graphics;
    
    public GraphicsRenderer(Graphics graphics)
    {
        _graphics = graphics;
        _graphics.SmoothingMode = SmoothingMode.AntiAlias;
    }
    
    private static Color ConvertColor(CustomColor color)
    {
        return Color.FromArgb(color.A, color.R, color.G, color.B);
    }
    
    public void VisitCircle(Circle circle)
    {
        var pos = circle.GetDrawingPosition();
        int diameter = 2 * circle.Radius;
        
        using var brush = new SolidBrush(ConvertColor(circle.FillColor));
        using var pen = new Pen(ConvertColor(circle.BorderColor));
        
        _graphics.FillEllipse(brush, pos.X - circle.Radius, pos.Y - circle.Radius, diameter, diameter);
        _graphics.DrawEllipse(pen, pos.X - circle.Radius, pos.Y - circle.Radius, diameter, diameter);
        
        if (!circle.IsSelected)
        {
            return;
        }
        
        using var selectionPen = new Pen(Color.Red, circle.SelectionBorderWidth);
        selectionPen.DashStyle = DashStyle.Dash;
        
        _graphics.DrawEllipse(selectionPen, pos.X - circle.Radius - circle.SelectionBorderWidth, pos.Y - circle.Radius - circle.SelectionBorderWidth, 
        diameter + 2 * circle.SelectionBorderWidth, diameter + 2 * circle.SelectionBorderWidth);
    }
    
    public void VisitParallelogram(Parallelogram parallelogram)
    {
        var pos = parallelogram.GetDrawingPosition();
        
        using var brush = new SolidBrush(ConvertColor(parallelogram.FillColor));
        using var pen = new Pen(ConvertColor(parallelogram.BorderColor));
        
        Point[] points =
        {
            new(pos.X, pos.Y),
            new(pos.X + parallelogram.Base, pos.Y),
            new(pos.X + parallelogram.Base - parallelogram.Side, pos.Y - parallelogram.Height),
            new(pos.X - parallelogram.Side, pos.Y - parallelogram.Height)
        };
        
        _graphics.FillPolygon(brush, points);
        _graphics.DrawPolygon(pen, points);
        
        if (!parallelogram.IsSelected)
        {
            return;
        }
        
        using var selectionPen = new Pen(Color.Red, parallelogram.SelectionBorderWidth);
        selectionPen.DashStyle = DashStyle.Dash;
        
        // Offset selection border
        Point[] selectionPoints =
        {
            new(pos.X - parallelogram.SelectionBorderWidth, pos.Y + parallelogram.SelectionBorderWidth),
            new(pos.X + parallelogram.Base + parallelogram.SelectionBorderWidth, pos.Y + parallelogram.SelectionBorderWidth),
            new(pos.X + parallelogram.Base - parallelogram.Side + parallelogram.SelectionBorderWidth, pos.Y - parallelogram.Height - parallelogram.SelectionBorderWidth),
            new(pos.X - parallelogram.Side - parallelogram.SelectionBorderWidth, pos.Y - parallelogram.Height - parallelogram.SelectionBorderWidth)
        };
        
        _graphics.DrawPolygon(selectionPen, selectionPoints);
    }
    
    public void VisitRectangle(RectangleShape rectangle)
    {
        var pos = rectangle.GetDrawingPosition();
        
        using Pen pen = new(ConvertColor(rectangle.BorderColor));
        using SolidBrush brush = new(ConvertColor(rectangle.FillColor));

        _graphics.FillRectangle(brush, pos.X, pos.Y, rectangle.Width, rectangle.Height);
        _graphics.DrawRectangle(pen, pos.X, pos.Y, rectangle.Width, rectangle.Height);

        if (!rectangle.IsSelected)
        {
            return;
        }
        
        using var selectionPen = new Pen(Color.Red, rectangle.SelectionBorderWidth);
        selectionPen.DashStyle = DashStyle.Dash;

        var rect = new Rectangle(pos.X - rectangle.SelectionBorderWidth, pos.Y - rectangle.SelectionBorderWidth,
        rectangle.Width + 2 * rectangle.SelectionBorderWidth,
        rectangle.Height + 2 * rectangle.SelectionBorderWidth
        );

        _graphics.DrawRectangle(selectionPen, rect);
    }
    
    public void VisitRhombus(Rhombus rhombus)
    {
        var pos = rhombus.GetDrawingPosition();
        using Pen pen = new(ConvertColor(rhombus.BorderColor));
        using SolidBrush brush = new(ConvertColor(rhombus.FillColor));
        
        Point[] points =
        {
            new(pos.X, pos.Y - rhombus.Diagonal1 / 2),
            new(pos.X + rhombus.Diagonal2 / 2, pos.Y),
            new(pos.X, pos.Y + rhombus.Diagonal1 / 2),
            new(pos.X - rhombus.Diagonal2 / 2, pos.Y)
        };
        
        _graphics.FillPolygon(brush, points);
        _graphics.DrawPolygon(pen, points);
        
        if (!rhombus.IsSelected)
        {
            return;
        }
        
        using var selectionPen = new Pen(Color.Red, rhombus.SelectionBorderWidth);
        selectionPen.DashStyle = DashStyle.Dash;
        
        // Offset selection border
        Point[] selectionPoints =
        {
            new(pos.X, pos.Y - rhombus.Diagonal1 / 2 - rhombus.SelectionBorderWidth),
            new(pos.X + rhombus.Diagonal2 / 2 + rhombus.SelectionBorderWidth, pos.Y),
            new(pos.X, pos.Y + rhombus.Diagonal1 / 2 + rhombus.SelectionBorderWidth),
            new(pos.X - rhombus.Diagonal2 / 2 - rhombus.SelectionBorderWidth, pos.Y)
        };
        
        _graphics.DrawPolygon(selectionPen, selectionPoints);
    }
    
    public void VisitTrapezoid(Trapezoid trapezoid)
    {
        var pos = trapezoid.GetDrawingPosition();
        using Pen pen = new(ConvertColor(trapezoid.BorderColor));
        using SolidBrush brush = new(ConvertColor(trapezoid.FillColor));
        
        Point[] points =
        {
            new(pos.X, pos.Y),  // Top-left corner
            new(pos.X + trapezoid.Base1, pos.Y),  // Top-right corner
            new(pos.X + trapezoid.Base1 - trapezoid.Base2 + (trapezoid.Base1 - trapezoid.Base2) / 2, pos.Y + trapezoid.Height),  // Bottom-right corner
            new(pos.X + (trapezoid.Base1 - trapezoid.Base2) / 2, pos.Y + trapezoid.Height)  // Bottom-left corner
        };
        
        _graphics.FillPolygon(brush, points);
        _graphics.DrawPolygon(pen, points);
        
        if (!trapezoid.IsSelected)
        {
            return;
        }
        
        using var selectionPen = new Pen(Color.Red, trapezoid.SelectionBorderWidth);
        selectionPen.DashStyle = DashStyle.Dash;
        
        // Offset selection border
        Point[] selectionPoints =
        {
            new(pos.X - trapezoid.SelectionBorderWidth, pos.Y - trapezoid.SelectionBorderWidth),
            new(pos.X + trapezoid.Base1 + trapezoid.SelectionBorderWidth, pos.Y - trapezoid.SelectionBorderWidth),
            new(pos.X + trapezoid.Base1 - trapezoid.Base2 + (trapezoid.Base1 - trapezoid.Base2) / 2 + trapezoid.SelectionBorderWidth, pos.Y + trapezoid.Height + trapezoid.SelectionBorderWidth),
            new(pos.X + (trapezoid.Base1 - trapezoid.Base2) / 2 - trapezoid.SelectionBorderWidth, pos.Y + trapezoid.Height + trapezoid.SelectionBorderWidth)
        };
        
        _graphics.DrawPolygon(selectionPen, selectionPoints);
    }
    
    public void VisitTriangle(Triangle triangle)
    {
        using Pen pen = new(ConvertColor(triangle.BorderColor));
        using SolidBrush brush = new(ConvertColor(triangle.FillColor));
        
        // Temporary offset
        Point[] points = 
        {
            new(triangle.Point1.X + triangle.TempOffsetX, triangle.Point1.Y + triangle.TempOffsetY),
            new(triangle.Point2.X + triangle.TempOffsetX, triangle.Point2.Y + triangle.TempOffsetY),
            new(triangle.Point3.X + triangle.TempOffsetX, triangle.Point3.Y + triangle.TempOffsetY)
        };
        
        _graphics.FillPolygon(brush, points);
        _graphics.DrawPolygon(pen, points);
        
        if (!triangle.IsSelected)
        {
            return;
        }
        
        using var selectionPen = new Pen(Color.Red, triangle.SelectionBorderWidth);
        selectionPen.DashStyle = DashStyle.Dash;
        
        // Offset selection border
        Point[] selectionPoints =
        {
            new(points[0].X - triangle.SelectionBorderWidth, points[0].Y - triangle.SelectionBorderWidth),
            new(points[1].X + triangle.SelectionBorderWidth, points[1].Y - triangle.SelectionBorderWidth),
            new(points[2].X, points[2].Y + triangle.SelectionBorderWidth)
        };
        
        _graphics.DrawPolygon(selectionPen, selectionPoints);
    }
}