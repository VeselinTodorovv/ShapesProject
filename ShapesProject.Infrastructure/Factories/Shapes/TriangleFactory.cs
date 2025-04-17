using ShapeProject.Application.Commands.Core;
using ShapesProject.Domain.Primitives;
using ShapesProject.Domain.Shapes;

namespace Infrastructure.Factories.Shapes;

public class TriangleFactory : IShapeFactory
{
    public Shape Create(params object[] args)
    {
        return new Triangle(
            (CustomPoint)args[0],
            (CustomPoint)args[1],
            (CustomPoint)args[2]
        );
    }
}