using System.Drawing;
using ShapesProject.Domain;
using ShapesProject.Utils.Commands.Core;
using ShapesProject.Utils.Commands.Edit;

namespace ShapesProject.Forms.CommandFactories;

public class CircleEditCommandFactory : IEditCommandFactory
{
    public ICommand Create(Shape currentShape, Shape oldShape)
    {
        if (currentShape is not Circle current || oldShape is not Circle old)
        {
            throw new ArgumentException("Invalid shape type.");
        }

        // TODO: add some converter method to simplify
        var oldFill = Color.FromArgb(old.FillColor.A, old.FillColor.R, old.FillColor.G, old.FillColor.B);
        var newFill = Color.FromArgb(current.FillColor.A, current.FillColor.R, current.FillColor.G, current.FillColor.B);
        
        var oldBorder = Color.FromArgb(old.BorderColor.A, old.BorderColor.R, old.BorderColor.G, old.BorderColor.B);
        var newBorder = Color.FromArgb(current.BorderColor.A, current.BorderColor.R, current.BorderColor.G, current.BorderColor.B);
        
        return new EditCircleCommand(
            current,
            old.Radius,
            current.Radius,
            oldFill,
            newFill,
            oldBorder,
            newBorder
        );
    }
}