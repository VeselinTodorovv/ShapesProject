using ShapeProject.Application.Commands.Core;
using ShapesProject.Domain.Shapes;

namespace Infrastructure.Factories.Commands;

public class EditCommandFactoryRegistry
{
    private readonly Dictionary<Type, IEditCommandFactory> _factories = new();
    
    public void Register<T>(IEditCommandFactory factory)
        where T : Shape
    {
        _factories.Add(typeof(T), factory);
    }
    
    public IEditCommandFactory GetFactory(Type shapeType)
    {
        if (!_factories.TryGetValue(shapeType, out var factory))
        {
            throw new ArgumentException($"No factory registered for shape type {shapeType.Name}");
        }
        
        return factory;
    }
}