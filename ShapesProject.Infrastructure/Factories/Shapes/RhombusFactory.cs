using ShapeProject.Application.Commands.Core;
using ShapesProject.Domain.Shapes;

namespace Infrastructure.Factories.Shapes;

public class RhombusFactory : IShapeFactory
{
    public Shape Create(params object[] args)
    {
        var x = (int)args[0];
        var y = (int)args[1];
        var diagonal1 = (int)args[2];
        var diagonal2 = (int)args[3];
        
        return new Rhombus(x, y, diagonal1, diagonal2);
    }
}