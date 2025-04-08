using ShapesProject.Models;

namespace ShapesProject.Utils.Commands
{
    class ChangeBorderColorCommand : CommandBase
    {
        private readonly Shape _shape;
        private readonly Color _newColor;
        private readonly Color _oldColor;

        public ChangeBorderColorCommand(Shape shape, Color newColor)
        {
            _shape = shape;
            _newColor = newColor;
            _oldColor = _shape.BorderColor;
        }

        public override void Execute()
        {
            if (_shape == null)
            {
                throw new InvalidOperationException("Shape is null");
            }
            if (_shape.BorderColor == _newColor)
            {
                return;
            }

            _shape.BorderColor = _newColor;
        }

        public override void Undo()
        {
            if (_shape == null)
            {
                throw new InvalidOperationException("Shape is null");
            }
            if (_shape.BorderColor == _oldColor)
            {
                return;
            }

            _shape.BorderColor = _oldColor;
        }
    }
}