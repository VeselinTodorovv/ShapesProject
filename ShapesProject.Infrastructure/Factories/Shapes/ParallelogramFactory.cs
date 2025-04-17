using ShapeProject.Application.Commands.Core;
using ShapesProject.Domain.Shapes;

namespace Infrastructure.Factories.Shapes;

public class ParallelogramFactory : IShapeFactory
{
    public Shape Create(params object[] args)
    {
        return new Parallelogram((int)args[0], (int)args[1], (int)args[2], (int)args[3], (int)args[4]);
    }
}