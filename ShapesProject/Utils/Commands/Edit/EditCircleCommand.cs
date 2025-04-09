using ShapesProject.Models;
using ShapesProject.Utils.Commands.Core;

namespace ShapesProject.Utils.Commands.Edit;

internal class EditCircleCommand : CommandBase
{
    private readonly Circle _circle;
    
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
        _circle.FillColor = _newFill;
        _circle.BorderColor = _newBorder;
    }
    
    public override void Undo()
    {
        _circle.EditSize(_oldRadius);
        _circle.FillColor = _oldFill;
        _circle.BorderColor = _oldBorder;
    }
}