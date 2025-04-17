using ShapeProject.Application.Commands.Core;
using ShapesProject.Domain.Shapes;

namespace Infrastructure.Factories.Shapes;

public abstract class ShapeFactory
{
    private static readonly Dictionary<Type, IShapeFactory> ShapeFactories = new();

    public static void RegisterFactory<TShape>(IShapeFactory factory) where TShape : Shape
    {
        ShapeFactories[typeof(TShape)] = factory;
    }

    public static Shape CreateShape<TShape>(params object[] parameters) where TShape : Shape
    {
        if (ShapeFactories.TryGetValue(typeof(TShape), out var factory))
        {
            return factory.Create(parameters);
        }

        throw new ArgumentException($"No factory registered for shape type {typeof(TShape).Name}");
    }
}