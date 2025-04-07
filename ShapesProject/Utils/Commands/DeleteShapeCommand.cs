using ShapesProject.Models;

namespace ShapesProject.Utils.Commands
{
    internal class DeleteShapeCommand : CommandBase
    {
        private readonly ShapeManager _manager;
        private readonly Shape _shape;

        private bool _executed;

        public DeleteShapeCommand(ShapeManager manager, Shape shape)
        {
            _manager = manager
                       ?? throw new ArgumentNullException(nameof(manager));
            _shape = shape
                     ?? throw new ArgumentNullException(nameof(shape));
        }

        public override void Execute()
        {
            if (_executed)
            {
                return;
            }

            _manager.DeleteShape(_shape);
            _executed = true;
        }

        public override void Undo()
        {
            EnsureState(_executed, "Cannot undo unexecuted command");

            _manager.AddShape(_shape);
            _executed = false;
        }
    }
}