using ShapeProject.Application.Commands.Core;
using ShapesProject.Domain.Shapes;

namespace Infrastructure.Factories.Shapes;

public class CircleFactory : IShapeFactory
{
    public Shape Create(params object[] args)
    {
        return new Circle((int)args[0], (int)args[1], (int)args[2]);
    }
}