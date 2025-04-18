using ShapeProject.Application.Commands.Core;
using ShapesProject.Domain.Shapes;

namespace Infrastructure.Factories.Shapes;

public class TrapezoidFactory : IShapeFactory
{
    public Shape Create(params object[] args)
    {
        var x = (int)args[0];
        var y = (int)args[1];
        var base1 = (int)args[2];
        var base2 = (int)args[3];
        var height = (int)args[4];
        
        return new Trapezoid(x, y, base1, base2, height);
    }
}