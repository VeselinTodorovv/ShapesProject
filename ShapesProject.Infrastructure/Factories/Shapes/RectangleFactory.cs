using ShapeProject.Application.Commands.Core;
using ShapesProject.Domain.Shapes;

namespace Infrastructure.Factories.Shapes;

public class RectangleFactory : IShapeFactory
{
    public Shape Create(params int[] args)
    {
        var x = args[0];
        var y = args[1];
        var width = args[2];
        var height = args[3];
        
        return new RectangleShape(x, y, width, height);
    }
}