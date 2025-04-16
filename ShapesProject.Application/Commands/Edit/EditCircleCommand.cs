using ShapeProject.Application.Commands.Core;
using ShapesProject.Domain.Primitives;
using ShapesProject.Domain.Shapes;

namespace ShapeProject.Application.Commands.Edit;

public class EditCircleCommand : CommandBase
{
    private readonly Circle _circle;
    
    private readonly int _oldRadius, _newRadius;
    
    private readonly CustomColor _oldFill, _newFill;
    private readonly CustomColor _oldBorder, _newBorder;
    
    public EditCircleCommand(Circle circle, int oldRadius, int newRadius,
        CustomColor oldFill, CustomColor newFill, CustomColor oldBorder, CustomColor newBorder)
    {
        _circle = circle;

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