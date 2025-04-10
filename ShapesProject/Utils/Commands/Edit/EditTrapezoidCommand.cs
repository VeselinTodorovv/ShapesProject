using ShapesProject.Domain.Primitives;
using ShapesProject.Domain.Shapes;
using ShapesProject.Utils.Commands.Core;

namespace ShapesProject.Utils.Commands.Edit;

internal class EditTrapezoidCommand : CommandBase
{
    private readonly Shape _trapezoid;
    
    private readonly int _oldBase1;
    private readonly int _newBase1;
    
    private readonly int _oldBase2;
    private readonly int _newBase2;
    
    private readonly int _oldHeight;
    private readonly int _newHeight;
    
    private readonly Color _oldFill;
    private readonly Color _newFill;
    
    private readonly Color _oldBorder;
    private readonly Color _newBorder;

    public EditTrapezoidCommand(Trapezoid trapezoid, int oldBase1, int newBase1, int oldBase2, int newBase2, int oldHeight, int newHeight,
        Color oldFill, Color newFill, Color oldBorder, Color newBorder)
    {
        _trapezoid = trapezoid
            ?? throw new ArgumentNullException(nameof(trapezoid));
        
        _oldBase1 = oldBase1;
        _newBase1 = newBase1;
        
        _oldBase2 = oldBase2;
        _newBase2 = newBase2;
        
        _oldHeight = oldHeight;
        _newHeight = newHeight;
        
        _oldFill = oldFill;
        _newFill = newFill;
        
        _oldBorder = oldBorder;
        _newBorder = newBorder;
    }

    public override void Execute()
    {
        _trapezoid.EditSize(_newBase1, _newBase2, _newHeight);
        
        var newFillColor = new CustomColor(_newFill.R, _newFill.G, _newFill.B, _newFill.A);
        var newBorderColor = new CustomColor(_newBorder.R, _newBorder.G, _newBorder.B, _newBorder.A);
        
        _trapezoid.FillColor = newFillColor;
        _trapezoid.BorderColor = newBorderColor;
    }
    
    public override void Undo()
    {
        _trapezoid.EditSize(_oldBase1, _oldBase2, _oldHeight);
        
        var oldFillColor = new CustomColor(_oldFill.R, _oldFill.G, _oldFill.B, _oldFill.A);
        var oldBorderColor = new CustomColor(_oldBorder.R, _oldBorder.G, _oldBorder.B, _oldBorder.A);
        
        _trapezoid.FillColor = oldFillColor;
        _trapezoid.BorderColor = oldBorderColor;
    }
}