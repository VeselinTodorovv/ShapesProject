using ShapeProject.Application.Commands.Core;
using ShapesProject.Domain.Shapes;

namespace Infrastructure.Factories.Shapes;

public class RhombusFactory : IShapeFactory
{
    public Shape Create(params int[] args)
    {
        var x = args[0];
        var y = args[1];
        var diagonal1 = args[2];
        var diagonal2 = args[3];
        
        return new Rhombus(x, y, diagonal1, diagonal2);
    }
}