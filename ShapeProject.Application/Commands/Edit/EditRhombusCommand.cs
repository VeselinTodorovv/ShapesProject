using System.Drawing;
using ShapeProject.Application.Commands.Core;
using ShapesProject.Domain.Primitives;
using ShapesProject.Domain.Shapes;

namespace ShapesProject.Utils.Commands.Edit;

public class EditRhombusCommand : CommandBase
{
    private readonly Shape _rhombus;
    
    private readonly int _oldDiagonal1;
    private readonly int _newDiagonal1;
    
    private readonly int _oldDiagonal2;
    private readonly int _newDiagonal2;
    
    private readonly Color _oldFill;
    private readonly Color _newFill;
    
    private readonly Color _oldBorder;
    private readonly Color _newBorder;
    
    public EditRhombusCommand(Rhombus rhombus, int oldDiagonal1, int newDiagonal1, int oldDiagonal2, int newDiagonal2,
        Color oldFill, Color newFill, Color oldBorder, Color newBorder)
    {
        _rhombus = rhombus 
                   ?? throw new ArgumentNullException(nameof(rhombus));
        
        _oldDiagonal1 = oldDiagonal1;
        _newDiagonal1 = newDiagonal1;
        
        _oldDiagonal2 = oldDiagonal2;
        _newDiagonal2 = newDiagonal2;
        
        _oldFill = oldFill;
        _newFill = newFill;
        
        _oldBorder = oldBorder;
        _newBorder = newBorder;
    }
    
    public override void Execute()
    {
        _rhombus.EditSize(_newDiagonal1, _newDiagonal2);
        
        // TODO: Follow the example in EditCircleCommand and remove UI logic
        var newFillColor = new CustomColor(_newFill.R, _newFill.G, _newFill.B, _newFill.A);
        var newBorderColor = new CustomColor(_newBorder.R, _newBorder.G, _newBorder.B, _newBorder.A);
        
        _rhombus.FillColor = newFillColor;
        _rhombus.BorderColor = newBorderColor;
    }
    
    public override void Undo()
    {
        _rhombus.EditSize(_oldDiagonal1, _oldDiagonal2);
        
        var oldFillColor = new CustomColor(_oldFill.A, _oldFill.R, _oldFill.G, _oldFill.B);
        var oldBorderColor = new CustomColor(_oldBorder.A, _oldBorder.R, _oldBorder.G, _oldBorder.B);
        
        _rhombus.FillColor = oldFillColor;
        _rhombus.BorderColor = oldBorderColor;

    }
}