using ShapeProject.Application.Commands.Core;
using ShapesProject.Domain.Primitives;
using ShapesProject.Domain.Shapes;

namespace ShapeProject.Application.Commands.Colors;

public class ChangeFillColorCommand : CommandBase
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