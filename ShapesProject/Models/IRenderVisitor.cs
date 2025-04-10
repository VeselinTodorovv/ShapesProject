namespace ShapesProject.Models;

public interface IRenderVisitor
{
    void VisitCircle(Circle circle);
    void VisitParallelogram(Parallelogram parallelogram);
    void VisitRectangle(RectangleShape rectangle);
    void VisitRhombus(Rhombus rhombus);
    void VisitTrapezoid(Trapezoid trapezoid);
    void VisitTriangle(Triangle triangle);
}