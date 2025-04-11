using ShapeProject.Application.Commands.Core;
using ShapeProject.Application.Commands.Edit;
using ShapesProject.Domain.Shapes;

namespace Infrastructure.Factories.Commands;

public class TriangleEditCommandFactory : IEditCommandFactory
{
    public ICommand Create(Shape currentShape, Shape oldShape)
    {
        if (currentShape is not Triangle current || oldShape is not Triangle old)
        {
            throw new ArgumentException("Invalid shape type");
        }

        return new EditTriangleCommand(
            current,
            old.Point1, current.Point1,
            old.Point2, current.Point2,
            old.Point3, current.Point3,
            old.FillColor, current.FillColor,
            old.BorderColor, current.BorderColor
        );
    }
}