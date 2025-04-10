using System.Drawing;
using ShapesProject.Domain;
using ShapesProject.Domain.Primitives;
using ShapesProject.Utils.Commands.Core;

namespace ShapesProject.Utils.Commands.Colors;

internal class ChangeFillColorCommand : CommandBase
{
    private readonly Shape _shape;
    private readonly Color _newColor;
    private readonly Color _oldColor;

    public ChangeFillColorCommand(Shape shape, Color newColor)
    {
        _shape = shape;
        _newColor = newColor;
        _oldColor = Color.FromArgb(_shape.FillColor.A, _shape.FillColor.R, _shape.FillColor.G, _shape.FillColor.B);
    }

    public override void Execute()
    {
        if (_shape == null)
        {
            throw new InvalidOperationException("Shape is null");
        }
        
        var fillColor = Color.FromArgb(_shape.BorderColor.A, _shape.BorderColor.R, _shape.BorderColor.G, _shape.BorderColor.B);
        if (fillColor == _newColor)
        {
            return;
        }

        _shape.FillColor = new CustomColor(_newColor.A, _newColor.R, _newColor.G, _newColor.B);
    }

    public override void Undo()
    {
        if (_shape == null)
        {
            throw new InvalidOperationException("Shape is null");
        }
        
        var fillColor = Color.FromArgb(_oldColor.A, _oldColor.R, _oldColor.G, _oldColor.B);
        if (fillColor == _oldColor)
        {
            return;
        }

        _shape.FillColor = new CustomColor(_oldColor.A, _oldColor.R, _oldColor.G, _oldColor.B);
    }
}