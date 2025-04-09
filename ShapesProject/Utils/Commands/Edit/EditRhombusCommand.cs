using ShapesProject.Models;
using ShapesProject.Utils.Commands.Core;

namespace ShapesProject.Utils.Commands.Edit;

internal class EditRhombusCommand : CommandBase
{
    private readonly Rhombus _rhombus;
    
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
        _rhombus.FillColor = _newFill;
        _rhombus.BorderColor = _newBorder;
    }
    
    public override void Undo()
    {
        _rhombus.EditSize(_oldDiagonal1, _oldDiagonal2);
        _rhombus.FillColor = _oldFill;
        _rhombus.BorderColor = _oldBorder;
    }
}