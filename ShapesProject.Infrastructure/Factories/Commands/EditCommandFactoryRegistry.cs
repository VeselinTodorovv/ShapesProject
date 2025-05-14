using ShapeProject.Application.Commands.Core;
using ShapesProject.Domain.Shapes;

namespace Infrastructure.Factories.Commands;

public abstract class EditCommandFactoryRegistry
{
    private static readonly Dictionary<Type, IEditCommandFactory> Factories = new();
    
    public static void Register<T>(IEditCommandFactory factory)
        where T : Shape
    {
        Factories[typeof(T)] = factory;
    }
    
    public static IEditCommandFactory GetFactory(Type shapeType)
    {
        if (!Factories.TryGetValue(shapeType, out var factory))
        {
            throw new ArgumentException($"No factory registered for shape type {shapeType.Name}");
        }
        
        return factory;
    }
}