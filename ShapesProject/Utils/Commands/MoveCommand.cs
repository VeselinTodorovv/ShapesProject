using ShapesProject.Models;

namespace ShapesProject.Utils.Commands
{
    class MoveCommand : CommandBase
    {
        private readonly Shape? _shape;
        private readonly int _dx, _dy;
        private bool _executed;

        public MoveCommand(Shape shape, int dx, int dy)
        {
            _shape = shape;
            _dx = dx;
            _dy = dy;
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
            
            _shape.Move(_dx, _dy);
            _executed = true;
        }

        public override void Undo()
        {
            if (!_executed)
            {
                return;
            }
            
            _shape?.Move(-_dx, -_dy);
            _executed = false;
        }
    }
}