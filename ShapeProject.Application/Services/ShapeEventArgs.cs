using ShapesProject.Domain.Shapes;

namespace ShapeProject.Application.Services;

public class ShapeEventArgs : EventArgs
{
    public Shape? Shape { get; }

    public ShapeEventArgs(Shape shape)
    {
        Shape = shape;
    }
}