using ShapesProject.Domain.Shapes;

namespace ShapesProject.Utils;

public class ShapeEventArgs : EventArgs
{
    public Shape? Shape { get; }

    public ShapeEventArgs(Shape shape)
    {
        Shape = shape;
    }
}