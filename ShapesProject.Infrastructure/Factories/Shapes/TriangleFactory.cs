using ShapeProject.Application.Commands.Core;
using ShapesProject.Domain.Primitives;
using ShapesProject.Domain.Shapes;

namespace Infrastructure.Factories.Shapes;

public class TriangleFactory : IShapeFactory
{
    public Shape Create(params int[] args)
    {
        var point1 = new CustomPoint(args[0], args[1]);
        var point2 = new CustomPoint(args[2], args[3]);
        var point3 = new CustomPoint(args[4], args[5]);
        
        return new Triangle(point1, point2, point3);
    }
}