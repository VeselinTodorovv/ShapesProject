using ShapesProject.Domain.Shapes;
using ShapesProject.Utils.Commands.Core;
using ShapesProject.Utils.Commands.Edit;

namespace ShapesProject.Forms.CommandFactories;

public class RectangleEditCommandFactory : IEditCommandFactory
{
    public ICommand Create(Shape currentShape, Shape oldShape)
    {
        if (currentShape is not RectangleShape current || oldShape is not RectangleShape old)
        {
            throw new ArgumentException("Invalid shape type.");
        }

        var oldFill = Color.FromArgb(old.FillColor.A, old.FillColor.R, old.FillColor.G, old.FillColor.B);
        var newFill = Color.FromArgb(current.FillColor.A, current.FillColor.R, current.FillColor.G, current.FillColor.B);
        
        var oldBorder = Color.FromArgb(old.BorderColor.A, old.BorderColor.R, old.BorderColor.G, old.BorderColor.B);
        var newBorder = Color.FromArgb(current.BorderColor.A, current.BorderColor.R, current.BorderColor.G, current.BorderColor.B);
        
        return new EditRectangleCommand(
            current,
            old.Width,
            current.Width,
            old.Height,
            current.Height,
            oldFill,
            newFill,
            oldBorder,
            newBorder
        );
    }
}