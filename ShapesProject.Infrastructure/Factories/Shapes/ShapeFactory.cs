using ShapeProject.Application.Commands.Core;
using ShapesProject.Domain.Shapes;

namespace Infrastructure.Factories.Shapes;

public abstract class ShapeFactory
{
    private static readonly Dictionary<Type, IShapeFactory> ShapeFactories = new();

    public static void RegisterFactory<T>(IShapeFactory factory)
        where T : Shape
    {
        ShapeFactories[typeof(T)] = factory;
    }

    public static Shape CreateShape<T>(params int[] parameters)
        where T : Shape
    {
        if (ShapeFactories.TryGetValue(typeof(T), out var factory))
        {
            return factory.Create(parameters);
        }

        throw new ArgumentException($"No factory registered for shape type {typeof(T).Name}");
    }
}