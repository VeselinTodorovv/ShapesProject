using ShapesProject.Domain.Primitives;
using ShapesProject.Domain.Shapes;

namespace Infrastructure.Factories.Shape;

public class ShapeFactory
{
    private static readonly Dictionary<string, Func<object[], ShapesProject.Domain.Shapes.Shape>> ShapeCreators = new()
    {
        { "Circle", args => new Circle((int)args[0], (int)args[1], (int)args[2]) },
        { "Parallelogram", args => new Parallelogram((int)args[0], (int)args[1], (int)args[2], (int)args[3], (int)args[4]) },
        { "RectangleShape", args => new RectangleShape((int)args[0], (int)args[1], (int)args[2], (int)args[3])},
        { "Rhombus", args => new Rhombus((int)args[0], (int)args[1], (int)args[2], (int)args[3]) },
        { "Trapezoid", args => new Trapezoid((int)args[0], (int)args[1], (int)args[2], (int)args[3], (int)args[4]) },
        
        { "Triangle", args => new Triangle(
        new CustomPoint((int)args[0], (int)args[1]),
        new CustomPoint((int)args[2], (int)args[3]),
        new CustomPoint((int)args[4], (int)args[5])) }
    };

    public static ShapesProject.Domain.Shapes.Shape CreateShape(string shapeType, params object[] parameters)
    {
        if (ShapeCreators.TryGetValue(shapeType, out var creator))
        {
            return creator(parameters);
        }
        
        throw new ArgumentException($"Invalid shape type: {shapeType}");
    }
}