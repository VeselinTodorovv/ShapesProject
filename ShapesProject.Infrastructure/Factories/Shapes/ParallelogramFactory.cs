using ShapeProject.Application.Commands.Core;
using ShapesProject.Domain.Shapes;

namespace Infrastructure.Factories.Shapes;

public class ParallelogramFactory : IShapeFactory
{
    public Shape Create(params object[] args)
    {
        var x = (int)args[0];
        var y = (int)args[1];
        var baseLength = (int)args[2];
        var height = (int)args[3];
        var side = (int)args[4];
        
        return new Parallelogram(x, y, baseLength, height, side);
    }
}