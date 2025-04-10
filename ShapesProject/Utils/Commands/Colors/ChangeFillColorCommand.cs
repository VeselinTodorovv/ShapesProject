using ShapesProject.Domain.Primitives;
using ShapesProject.Domain.Shapes;
using ShapesProject.Utils.Commands.Core;

namespace ShapesProject.Utils.Commands.Colors;

internal class ChangeFillColorCommand : CommandBase
{
    private readonly Shape _shape;
    private readonly CustomColor _newColor;
    private readonly CustomColor _oldColor;

    public ChangeFillColorCommand(Shape shape, CustomColor newColor)
    {
        _shape = shape;
        _newColor = newColor;
        _oldColor = shape.FillColor;
    }

    public override void Execute() => _shape.FillColor = _newColor;
    public override void Undo() => _shape.FillColor = _oldColor;
}