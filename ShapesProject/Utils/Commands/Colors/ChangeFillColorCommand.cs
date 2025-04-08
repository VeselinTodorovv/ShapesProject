using ShapesProject.Models;
using ShapesProject.Utils.Commands.Core;

namespace ShapesProject.Utils.Commands.Colors
{
    internal class ChangeFillColorCommand : CommandBase
    {
        private readonly Shape _shape;
        private readonly Color _newColor;
        private readonly Color _oldColor;

        public ChangeFillColorCommand(Shape shape, Color newColor)
        {
            _shape = shape;
            _newColor = newColor;
            _oldColor = _shape.FillColor;
        }

        public override void Execute()
        {
            if (_shape == null)
            {
                throw new InvalidOperationException("Shape is null");
            }
            if (_shape.FillColor == _newColor)
            {
                return;
            }

            _shape.FillColor = _newColor;
        }

        public override void Undo()
        {
            if (_shape == null)
            {
                throw new InvalidOperationException("Shape is null");
            }
            if (_shape.FillColor == _oldColor)
            {
                return;
            }

            _shape.FillColor = _oldColor;
        }
    }
}