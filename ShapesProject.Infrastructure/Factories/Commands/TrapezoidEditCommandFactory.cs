using ShapeProject.Application.Commands.Core;
using ShapeProject.Application.Commands.Edit;
using ShapesProject.Domain.Shapes;

namespace Infrastructure.Factories.Commands;

public class TrapezoidEditCommandFactory : IEditCommandFactory
{
    public ICommand Create(Shape currentShape, Shape oldShape)
    {
        if (currentShape is not Trapezoid current || oldShape is not Trapezoid old)
        {
            throw new ArgumentException("Invalid shape type.");
        }
        
        return new EditTrapezoidCommand(
            current,
            old.Base1, current.Base1,
            old.Base2, current.Base2,
            old.Height, current.Height,
            old.FillColor, current.FillColor,
            old.BorderColor, current.BorderColor
        );
    }
}