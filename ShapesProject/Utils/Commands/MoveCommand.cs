using ShapesProject.Models;

namespace ShapesProject.Utils.Commands;

class MoveCommand : CommandBase
{
    private readonly Shape? _shape;
    private int _totalDx, _totalDy;
    private bool _executed;

    public MoveCommand(Shape shape, int dx, int dy)
    {
        _shape = shape
            ?? throw new ArgumentNullException(nameof(shape));
        _totalDx = dx;
        _totalDy = dy;
    }

    public void AccumulateMovement(int dx, int dy)
    {
        if (_executed)
        {
            throw new InvalidOperationException("Cannot accumulate movement after execution");
        }

        _totalDx += dx;
        _totalDy += dy;
    }

    public override void Execute()
    {
        if (_shape == null)
        {
            return;
        }

        if (_executed)
        {
            return;
        }
            
        _shape.Move(_totalDx, _totalDy);
        _executed = true;
    }

    public override void Undo()
    {
        if (!_executed)
        {
            return;
        }
            
        _shape?.Move(-_totalDx, -_totalDy);
        _executed = false;
    }
}