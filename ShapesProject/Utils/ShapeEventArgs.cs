using ShapesProject.Models;

namespace ShapesProject.Utils;

public class ShapeEventArgs : EventArgs
{
    public Shape Shape { get; }

    public ShapeEventArgs(Shape shape)
    {
        Shape = shape ?? throw new ArgumentNullException(nameof(shape));
    }
}