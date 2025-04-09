using ShapesProject.Models;
using ShapesProject.Utils.Commands.Core;

namespace ShapesProject.Utils.Commands.Selection;

internal class SelectCommand : CommandBase
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