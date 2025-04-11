using ShapeProject.Application.Commands.Core;
using ShapeProject.Application.Commands.Edit;
using ShapesProject.Domain.Shapes;

namespace Infrastructure.Factories.Commands;

public class RhombusEditCommandFactory : IEditCommandFactory
{
    public ICommand Create(Shape currentShape, Shape oldShape)
    {
        if (currentShape is not Rhombus current || oldShape is not Rhombus old)
        {
            throw new ArgumentException("Invalid shape type.");
        }
        
        return new EditRhombusCommand(
            current,
            old.Diagonal1, current.Diagonal1,
            old.Diagonal2, current.Diagonal2,
            old.FillColor, current.FillColor,
            old.BorderColor, current.BorderColor
        );
    }
}