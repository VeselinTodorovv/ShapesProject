using ShapeProject.Application.Commands.Core;
using ShapesProject.Domain.Shapes;

namespace Infrastructure.Factories.Shapes;

public class TrapezoidFactory : IShapeFactory
{
    public Shape Create(params int[] args)
    {
        var x = args[0];
        var y = args[1];
        var base1 = args[2];
        var base2 = args[3];
        var height = args[4];
        
        return new Trapezoid(x, y, base1, base2, height);
    }
}