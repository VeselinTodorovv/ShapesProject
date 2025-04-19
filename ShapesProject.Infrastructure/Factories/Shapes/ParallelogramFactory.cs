using ShapeProject.Application.Commands.Core;
using ShapesProject.Domain.Shapes;

namespace Infrastructure.Factories.Shapes;

public class ParallelogramFactory : IShapeFactory
{
    public Shape Create(params int[] args)
    {
        var x = args[0];
        var y = args[1];
        var baseLength = args[2];
        var height = args[3];
        var side = args[4];
        
        return new Parallelogram(x, y, baseLength, height, side);
    }
}