using ShapeProject.Application.Commands.Core;
using ShapesProject.Domain.Primitives;
using ShapesProject.Domain.Shapes;

namespace ShapeProject.Application.Commands.Edit;

public class EditRectangleCommand : CommandBase
{
    private readonly Shape _rectangle;
    
    private readonly int _oldWidth, _newWidth;
    private readonly int _oldHeight, _newHeight;
    
    private readonly CustomColor _oldFill, _newFill;
    private readonly CustomColor _oldBorder, _newBorder;

    public EditRectangleCommand(RectangleShape rectangle, int oldWidth, int newWidth, int oldHeight, int newHeight,
        CustomColor oldFill, CustomColor newFill, CustomColor oldBorder, CustomColor newBorder)
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