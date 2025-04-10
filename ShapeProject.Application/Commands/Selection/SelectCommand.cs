using ShapeProject.Application.Commands.Core;
using ShapesProject.Domain.Shapes;

namespace ShapeProject.Application.Commands.Selection;

public class SelectCommand : CommandBase
{
    private readonly Shape _shape;
    private readonly bool _newState;
    private bool _previousState;

    public SelectCommand(Shape shape, bool select)
    {
        _shape = shape
                 ?? throw new ArgumentNullException(nameof(shape));
        _newState = select;
    }

    public override void Execute()
    {
        _previousState = _shape.IsSelected;
        _shape.IsSelected = _newState;
    }

    public override void Undo() => _shape.IsSelected = _previousState;
}