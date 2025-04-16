using ShapesProject.Domain.Shapes;

namespace ShapeProject.Application.Commands.Core;

public interface IEditCommandFactory
{
    ICommand Create(Shape currentShape, Shape oldShape);
}