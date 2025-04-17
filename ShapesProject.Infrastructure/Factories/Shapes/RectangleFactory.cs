using ShapeProject.Application.Commands.Core;
using ShapesProject.Domain.Shapes;

namespace Infrastructure.Factories.Shapes;

public class RectangleFactory : IShapeFactory
{
    public Shape Create(params object[] args)
    {
        var x = (int)args[0];
        var y = (int)args[1];
        var width = (int)args[2];
        var height = (int)args[3];
        
        return new RectangleShape(x, y, width, height);
    }
}