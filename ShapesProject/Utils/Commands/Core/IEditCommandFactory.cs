using ShapesProject.Domain;

namespace ShapesProject.Utils.Commands.Core;

public interface IEditCommandFactory
{
    ICommand Create(Shape currentShape, Shape oldShape);
}