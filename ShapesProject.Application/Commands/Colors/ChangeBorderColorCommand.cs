using ShapeProject.Application.Commands.Core;
using ShapesProject.Domain.Primitives;
using ShapesProject.Domain.Shapes;

namespace ShapeProject.Application.Commands.Colors;

public class ChangeBorderColorCommand : CommandBase
{
    private readonly Shape _shape;
    private readonly CustomColor _newColor;
    private readonly CustomColor _oldColor;

    public ChangeBorderColorCommand(Shape shape, CustomColor newColor)
    {
        _shape = shape;
        _newColor = newColor;
        _oldColor = shape.BorderColor;
    }

    public override void Execute() => _shape.BorderColor = _newColor;
    public override void Undo() => _shape.BorderColor = _oldColor;
}