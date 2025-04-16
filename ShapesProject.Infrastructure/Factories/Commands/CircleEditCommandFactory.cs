using ShapeProject.Application.Commands.Core;
using ShapeProject.Application.Commands.Edit;
using ShapesProject.Domain.Shapes;

namespace Infrastructure.Factories.Commands;

public class CircleEditCommandFactory : IEditCommandFactory
{
    public ICommand Create(Shape currentShape, Shape oldShape)
    {
        if (currentShape is not Circle current || oldShape is not Circle old)
        {
            throw new ArgumentException("Invalid shape type.");
        }
        
        return new EditCircleCommand(
            current,
            old.Radius, current.Radius,
            old.FillColor, current.FillColor,
            old.BorderColor, current.BorderColor
        );
    }
}