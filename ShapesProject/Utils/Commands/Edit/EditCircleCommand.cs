using ShapesProject.Domain.Primitives;
using ShapesProject.Domain.Shapes;
using ShapesProject.Utils.Commands.Core;

namespace ShapesProject.Utils.Commands.Edit;

internal class EditCircleCommand : CommandBase
{
    private readonly Shape _circle;
    
    private readonly int _oldRadius;
    private readonly int _newRadius;
    
    private readonly Color _oldFill;
    private readonly Color _newFill;
    
    private readonly Color _oldBorder;
    private readonly Color _newBorder;
    
    public EditCircleCommand(Circle circle, int oldRadius, int newRadius,
        Color oldFill, Color newFill, Color oldBorder, Color newBorder)
    {
        _circle = circle
                  ?? throw new ArgumentNullException(nameof(circle));

        _oldRadius = oldRadius;
        _newRadius = newRadius;
        
        _oldFill = oldFill;
        _newFill = newFill;
        
        _oldBorder = oldBorder;
        _newBorder = newBorder;
    }

    public override void Execute()
    {
        _circle.EditSize(_newRadius);
        
        var newFillColor = new CustomColor(_newFill.R, _newFill.G, _newFill.B, _newFill.A);
        var newBorderColor = new CustomColor(_newBorder.R, _newBorder.G, _newBorder.B, _newBorder.A);
        
        _circle.FillColor = newFillColor;
        _circle.BorderColor = newBorderColor;
    }
    
    public override void Undo()
    {
        _circle.EditSize(_oldRadius);
        
        var oldFillColor = new CustomColor(_oldFill.R, _oldFill.G, _oldFill.B, _oldFill.A);
        var oldBorderColor = new CustomColor(_oldBorder.R, _oldBorder.G, _oldBorder.B, _oldBorder.A);
        
        _circle.FillColor = oldFillColor;
        _circle.BorderColor = oldBorderColor;
    }
}