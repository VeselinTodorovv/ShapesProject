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

    }
    
    public void VisitRectangle(RectangleShape rectangle)
    {
        var offsetX = (_previewSize.Width - rectangle.Width) / 2;
        var offsetY = (_previewSize.Height - rectangle.Height) / 2;
        
        _graphics.DrawRectangle(Pens.Black, offsetX, offsetY, rectangle.Width, rectangle.Height);
    }
    
    public void VisitRhombus(Rhombus rhombus)
    {
        throw new NotImplementedException();
    }
    
    public void VisitTrapezoid(Trapezoid trapezoid)
    {
        throw new NotImplementedException();
    }
    
    public void VisitTriangle(Triangle triangle)
    {
    }
}