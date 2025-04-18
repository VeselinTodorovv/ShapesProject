using Infrastructure.Converters;
using ShapesProject.Domain.Rendering;
using ShapesProject.Domain.Shapes;

namespace ShapesProject.Forms.Renderers;

public class PreviewRenderer : IRenderVisitor
{
    private readonly Graphics _graphics;
    private readonly Size _previewSize;

    public PreviewRenderer(Graphics graphics, Size previewSize)
    {
        _graphics = graphics;
        _previewSize = previewSize;
    }

    public void VisitCircle(Circle circle)
    {
        var offsetX = (_previewSize.Width - circle.Radius * 2) / 2;
        var offsetY = (_previewSize.Height - circle.Radius * 2) / 2;
        
        using SolidBrush brush = new(CustomColorConverter.ToSystemColor(circle.FillColor));
        using Pen pen = new(CustomColorConverter.ToSystemColor(circle.BorderColor));
        
        _graphics.FillEllipse(brush, offsetX, offsetY, circle.Radius * 2, circle.Radius * 2);
        _graphics.DrawEllipse(pen, offsetX, offsetY, circle.Radius * 2, circle.Radius * 2);
    }
    
    public void VisitParallelogram(Parallelogram parallelogram)
    {
        var offsetX = _previewSize.Width / 2;
        var offsetY = _previewSize.Height / 2;

        Point[] points =
        {
            new(offsetX, offsetY),
            new(offsetX + parallelogram.Base, offsetY),
            new(offsetX + parallelogram.Base - parallelogram.Side, offsetY - parallelogram.Height),
            new(offsetX - parallelogram.Side, offsetY - parallelogram.Height)
        };
        
        using SolidBrush brush = new(CustomColorConverter.ToSystemColor(parallelogram.FillColor));
        using Pen pen = new(CustomColorConverter.ToSystemColor(parallelogram.BorderColor));
        
        _graphics.FillPolygon(brush, points);
        _graphics.DrawPolygon(pen, points);
    }
    
    public void VisitRectangle(RectangleShape rectangle)
    {
        var offsetX = (_previewSize.Width - rectangle.Width) / 2;
        var offsetY = (_previewSize.Height - rectangle.Height) / 2;
        
        using SolidBrush brush = new(CustomColorConverter.ToSystemColor(rectangle.FillColor));
        using Pen pen = new(CustomColorConverter.ToSystemColor(rectangle.BorderColor));
    
        _graphics.FillRectangle(brush, offsetX, offsetY, rectangle.Width, rectangle.Height);
        _graphics.DrawRectangle(pen, offsetX, offsetY, rectangle.Width, rectangle.Height);
    }
    
    public void VisitRhombus(Rhombus rhombus)
    {
        var offsetX = _previewSize.Width / 2;
        var offsetY = _previewSize.Height / 2;

        Point[] points =
        {
            new(offsetX, offsetY - rhombus.Diagonal1 / 2),
            new(offsetX + rhombus.Diagonal2 / 2, offsetY),
            new(offsetX, offsetY + rhombus.Diagonal1 / 2),
            new(offsetX - rhombus.Diagonal2 / 2, offsetY)
        };

        using SolidBrush brush = new(CustomColorConverter.ToSystemColor(rhombus.FillColor));
        using Pen pen = new(CustomColorConverter.ToSystemColor(rhombus.BorderColor));

        _graphics.FillPolygon(brush, points);
        _graphics.DrawPolygon(pen, points);
    }
    
    public void VisitTrapezoid(Trapezoid trapezoid)
    {
        var pos = trapezoid.GetDrawingPosition();
        Point[] points =
        {
            new(pos.X, pos.Y),
            new(pos.X + trapezoid.Base1, pos.Y),
            new(pos.X + trapezoid.Base1 - trapezoid.Base2 + (trapezoid.Base1 - trapezoid.Base2) / 2, pos.Y + trapezoid.Height),
            new(pos.X + (trapezoid.Base1 - trapezoid.Base2) / 2, pos.Y + trapezoid.Height)
        };

        int minX = points.Min(p => p.X);
        int maxX = points.Max(p => p.X);
        int minY = points.Min(p => p.Y);
        int maxY = points.Max(p => p.Y);
        
        int shapeWidth = maxX - minX;
        int shapeHeight = maxY - minY;

        int targetX = (_previewSize.Width - shapeWidth) / 2;
        int targetY = (_previewSize.Height - shapeHeight) / 2;

        int dx = targetX - minX;
        int dy = targetY - minY;

        var centeredPoints = points
            .Select(p => new Point(p.X + dx, p.Y + dy))
            .ToArray();

        using SolidBrush brush = new(CustomColorConverter.ToSystemColor(trapezoid.FillColor));
        using Pen pen = new(CustomColorConverter.ToSystemColor(trapezoid.BorderColor));
        
        _graphics.FillPolygon(brush, centeredPoints);
        _graphics.DrawPolygon(pen, centeredPoints);
    }
    
    public void VisitTriangle(Triangle triangle)
    {
        var points = new[]
        {
            new Point(triangle.Point1.X, triangle.Point1.Y),
            new Point(triangle.Point2.X, triangle.Point2.Y),
            new Point(triangle.Point3.X, triangle.Point3.Y)
        };

        int minX = points.Min(p => p.X);
        int maxX = points.Max(p => p.X);
        int minY = points.Min(p => p.Y);
        int maxY = points.Max(p => p.Y);

        int triangleWidth = maxX - minX;
        int triangleHeight = maxY - minY;

        int offsetX = (_previewSize.Width - triangleWidth) / 2 - minX;
        int offsetY = (_previewSize.Height - triangleHeight) / 2 - minY;

        var shiftedPoints = points
            .Select(p => new Point(p.X + offsetX, p.Y + offsetY))
            .ToArray();

        using SolidBrush brush = new(CustomColorConverter.ToSystemColor(triangle.FillColor));
        using Pen pen = new(CustomColorConverter.ToSystemColor(triangle.BorderColor));

        _graphics.FillPolygon(brush, shiftedPoints);
        _graphics.DrawPolygon(pen, shiftedPoints);
    }
}