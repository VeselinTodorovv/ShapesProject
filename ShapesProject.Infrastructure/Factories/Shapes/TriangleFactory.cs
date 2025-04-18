using ShapeProject.Application.Commands.Core;
using ShapesProject.Domain.Primitives;
using ShapesProject.Domain.Shapes;

namespace Infrastructure.Factories.Shapes;

public class TriangleFactory : IShapeFactory
{
    public Shape Create(params object[] args)
    {
        var point1 = new CustomPoint((int)args[0], (int)args[1]);
        var point2 = new CustomPoint((int)args[2], (int)args[3]);
        var point3 = new CustomPoint((int)args[4], (int)args[5]);
        
        return new Triangle(point1, point2, point3);
    }
}