using ShapeProject.Application.Commands.Core;
using ShapesProject.Domain.Shapes;

namespace Infrastructure.Factories.Shapes;

public class CircleFactory : IShapeFactory
{
    public Shape Create(params int[] args)
    {
        var x = args[0];
        var y = args[1];
        var radius = args[2];
        
        return new Circle(x, y, radius);
    }
}