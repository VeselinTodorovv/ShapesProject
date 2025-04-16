using ShapesProject.Domain.Primitives;
using ShapesProject.Domain.Shapes;

namespace Infrastructure.Factories.Shapes;

public abstract class ShapeFactory
{
    private static readonly Dictionary<Type, Func<int[], Shape>> ShapeCreators = new()
    {
        { typeof(Circle), args => new Circle(args[0], args[1], args[2]) },
        { typeof(Parallelogram), args => new Parallelogram(args[0], args[1], args[2], args[3], args[4]) },
        { typeof(RectangleShape), args => new RectangleShape(args[0], args[1], args[2], args[3])},
        { typeof(Rhombus), args => new Rhombus(args[0], args[1], args[2], args[3]) },
        { typeof(Trapezoid), args => new Trapezoid(args[0], args[1], args[2], args[3], args[4]) },
        { typeof(Triangle), args => new Triangle(
        new CustomPoint(args[0], args[1]),
        new CustomPoint(args[2], args[3]),
        new CustomPoint(args[4], args[5])) }
    };

    public static Shape CreateShape(Type shapeType, params int[] parameters)
    {
        if (ShapeCreators.TryGetValue(shapeType, out var creator))
        {
            return creator(parameters);
        }
        
        throw new ArgumentException($"Invalid shape type: {shapeType}");
    }
}