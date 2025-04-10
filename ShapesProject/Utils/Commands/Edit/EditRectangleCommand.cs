using ShapesProject.Models;
using ShapesProject.Utils.Commands.Core;

namespace ShapesProject.Utils.Commands.Edit;

internal class EditRectangleCommand : CommandBase
{
    private readonly Shape _rectangle;
    
    private readonly int _oldWidth;
    private readonly int _newWidth;
    
    private readonly int _oldHeight;
    private readonly int _newHeight;
    
    private readonly Color _oldFill;
    private readonly Color _newFill;
    
    private readonly Color _oldBorder;
    private readonly Color _newBorder;

    public EditRectangleCommand(RectangleShape rectangle, int oldWidth, int newWidth, int oldHeight, int newHeight,
        Color oldFill, Color newFill, Color oldBorder, Color newBorder)
    {
        _rectangle = rectangle
                     ?? throw new ArgumentNullException(nameof(rectangle));
        
        _oldWidth = oldWidth;
        _newWidth = newWidth;
        
        _oldHeight = oldHeight;
        _newHeight = newHeight;
        
        _oldFill = oldFill;
        _newFill = newFill;
        
        _oldBorder = oldBorder;
        _newBorder = newBorder;
    }

    public override void Execute()
    {
        _rectangle.EditSize(_newWidth, _newHeight);
        _rectangle.FillColor = _newFill;
        _rectangle.BorderColor = _newBorder;
    }
    public override void Undo()
    {
        _rectangle.EditSize(_oldWidth, _oldHeight);
        _rectangle.FillColor = _oldFill;
        _rectangle.BorderColor = _oldBorder;
    }
}