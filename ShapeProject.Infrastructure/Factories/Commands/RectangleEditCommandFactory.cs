using ShapeProject.Application.Commands.Core;
using ShapeProject.Application.Commands.Edit;
using ShapesProject.Domain.Shapes;

namespace Infrastructure.Factories.Commands;

public class RectangleEditCommandFactory : IEditCommandFactory
{
    public ICommand Create(Shape currentShape, Shape oldShape)
    {
        if (currentShape is not RectangleShape current || oldShape is not RectangleShape old)
        {
            throw new ArgumentException("Invalid shape type.");
        }
        
        return new EditRectangleCommand(
            current,
            old.Width, current.Width,
            old.Height, current.Height,
            old.FillColor, current.FillColor,
            old.BorderColor, current.BorderColor
        );
    }
}