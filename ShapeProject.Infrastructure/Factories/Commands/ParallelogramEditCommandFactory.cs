using ShapeProject.Application.Commands.Core;
using ShapeProject.Application.Commands.Edit;
using ShapesProject.Domain.Shapes;

namespace Infrastructure.Factories.Commands;

public class ParallelogramEditCommandFactory : IEditCommandFactory
{
    public ICommand Create(Shape currentShape, Shape oldShape)
    {
        if (currentShape is not Parallelogram current || oldShape is not Parallelogram old)
        {
            throw new ArgumentException("Invalid shape type.");
        }
        
        return new EditParallelogramCommand(
            current,
            old.Base,
            current.Base,
            old.Height,
            current.Height,
            old.Side,
            current.Side,
            old.FillColor,
            current.FillColor,
            old.BorderColor,
            current.BorderColor
        );
    }
}