using ShapeProject.Application.Commands.Core;
using ShapesProject.Domain.Shapes;

namespace Infrastructure.Factories.Shapes;

public class CircleFactory : IShapeFactory
{
    public Shape Create(params object[] args)
    {
        var x = (int)args[0];
        var y = (int)args[1];
        var radius = (int)args[2];
        
        return new Circle(x, y, radius);
    }
}