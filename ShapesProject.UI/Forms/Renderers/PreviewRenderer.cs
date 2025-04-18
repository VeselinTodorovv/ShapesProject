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
        
        _graphics.DrawEllipse(Pens.Black, offsetX, offsetY, circle.Radius * 2, circle.Radius * 2);
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
        
        _graphics.DrawPolygon(Pens.Black, points);
    }
    
    public void VisitRectangle(RectangleShape rectangle)
    {
        var offsetX = (_previewSize.Width - rectangle.Width) / 2;
        var offsetY = (_previewSize.Height - rectangle.Height) / 2;
        
        _graphics.DrawRectangle(Pens.Black, offsetX, offsetY, rectangle.Width, rectangle.Height);
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

        _graphics.DrawPolygon(Pens.Black, points);

    }
    
    public void VisitTrapezoid(Trapezoid trapezoid)
    {
        throw new NotImplementedException();
    }
    
    public void VisitTriangle(Triangle triangle)
    {
        throw new NotImplementedException();
    }
}