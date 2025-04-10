using System.Drawing;
using ShapeProject.Application.Commands.Core;
using ShapesProject.Domain.Primitives;
using ShapesProject.Domain.Shapes;

namespace ShapeProject.Application.Commands.Edit;

public class EditRectangleCommand : CommandBase
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
        
        // TODO: Follow the example in EditCircleCommand and remove UI logic
        var newFillColor = new CustomColor(_newFill.R, _newFill.G, _newFill.B, _newFill.A);
        var newBorderColor = new CustomColor(_newBorder.R, _newBorder.G, _newBorder.B, _newBorder.A);
        
        _rectangle.FillColor = newFillColor;
        _rectangle.BorderColor = newBorderColor;
    }
    public override void Undo()
    {
        _rectangle.EditSize(_oldWidth, _oldHeight);
        
        var oldFillColor = new CustomColor(_oldFill.R, _oldFill.G, _oldFill.B, _oldFill.A);
        var oldBorderColor = new CustomColor(_oldBorder.R, _oldBorder.G, _oldBorder.B, _oldBorder.A);
        
        _rectangle.FillColor = oldFillColor;
        _rectangle.BorderColor = oldBorderColor;
    }
}