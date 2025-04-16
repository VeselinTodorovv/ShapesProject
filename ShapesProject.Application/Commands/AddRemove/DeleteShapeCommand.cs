using ShapeProject.Application.Commands.Core;
using ShapeProject.Application.Services;
using ShapesProject.Domain.Shapes;

namespace ShapeProject.Application.Commands.AddRemove
{
    public class DeleteShapeCommand : CommandBase
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