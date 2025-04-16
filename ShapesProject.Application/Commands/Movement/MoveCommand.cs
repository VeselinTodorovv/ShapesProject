using ShapeProject.Application.Commands.Core;
using ShapesProject.Domain.Shapes;

namespace ShapeProject.Application.Commands.Movement;

public class MoveCommand : CommandBase
{
    private readonly Shape? _shape;
    private bool _executed;
    
    public int TotalDx { get; private set; }

    public int TotalDy { get; private set; }

    public MoveCommand(Shape shape, int dx, int dy)
    {
        _shape = shape
            ?? throw new ArgumentNullException(nameof(shape));
        
        TotalDx = dx;
        TotalDy = dy;
    }

    public void AccumulateMovement(int dx, int dy)
    {
        if (_executed)
        {
            throw new InvalidOperationException("Cannot accumulate movement after execution");
        }

        TotalDx += dx;
        TotalDy += dy;
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
            
        _shape.Move(TotalDx, TotalDy);
        _executed = true;
    }

    public override void Undo()
    {
        if (!_executed)
        {
            return;
        }
            
        _shape?.Move(-TotalDx, -TotalDy);
        _executed = false;
    }
}