using System.Drawing;
using ShapeProject.Application.Commands.Core;
using ShapeProject.Application.Commands.Edit;
using ShapesProject.Domain.Shapes;

namespace Infrastructure.Factories.Command;

public class TrapezoidEditCommandFactory : IEditCommandFactory
{
    public ICommand Create(ShapesProject.Domain.Shapes.Shape currentShape, ShapesProject.Domain.Shapes.Shape oldShape)
    {
        if (currentShape is not Trapezoid current || oldShape is not Trapezoid old)
        {
            throw new ArgumentException("Invalid shape type.");
        }

        var oldFill = Color.FromArgb(old.FillColor.A, old.FillColor.R, old.FillColor.G, old.FillColor.B);
        var newFill = Color.FromArgb(current.FillColor.A, current.FillColor.R, current.FillColor.G, current.FillColor.B);
        
        var oldBorder = Color.FromArgb(old.BorderColor.A, old.BorderColor.R, old.BorderColor.G, old.BorderColor.B);
        var newBorder = Color.FromArgb(current.BorderColor.A, current.BorderColor.R, current.BorderColor.G, current.BorderColor.B);
        
        return new EditTrapezoidCommand(
            current,
            old.Base1,
            current.Base1,
            old.Base2,
            current.Base2,
            old.Height,
            current.Height,
            oldFill,
            newFill,
            oldBorder,
            newBorder
        );
    }
}