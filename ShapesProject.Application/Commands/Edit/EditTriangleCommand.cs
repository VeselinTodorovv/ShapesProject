using ShapeProject.Application.Commands.Core;
using ShapesProject.Domain.Primitives;
using ShapesProject.Domain.Shapes;

namespace ShapeProject.Application.Commands.Edit;

public class EditTriangleCommand : CommandBase
{
    private readonly Triangle _triangle;

    private readonly CustomPoint _oldPoint1, _newPoint1;
    private readonly CustomPoint _oldPoint2, _newPoint2;
    private readonly CustomPoint _oldPoint3, _newPoint3;
    
    private readonly CustomColor _oldFill, _newFill;
    private readonly CustomColor _oldBorder, _newBorder;

    public EditTriangleCommand(Triangle triangle, CustomPoint oldPoint1, CustomPoint newPoint1, CustomPoint oldPoint2, CustomPoint newPoint2, CustomPoint oldPoint3, CustomPoint newPoint3,
        CustomColor oldFill, CustomColor newFill, CustomColor oldBorder, CustomColor newBorder)
    {
        _triangle = triangle
            ?? throw new ArgumentNullException(nameof(triangle));
        
        _oldPoint1 = oldPoint1;
        _newPoint1 = newPoint1;
        
        _oldPoint2 = oldPoint2;
        _newPoint2 = newPoint2;
        
        _oldPoint3 = oldPoint3;
        _newPoint3 = newPoint3;
        
        _oldFill = oldFill;
        _newFill = newFill;
        
        _oldBorder = oldBorder;
        _newBorder = newBorder;
    }

    public override void Execute()
    {
        _triangle.EditSize(_newPoint1.X, _newPoint1.Y, _newPoint2.X, _newPoint2.Y, _newPoint3.X, _newPoint3.Y);
        
        _triangle.FillColor = _newFill;
        _triangle.BorderColor = _newBorder;
    }
    
    public override void Undo()
    {
        _triangle.EditSize(_oldPoint1.X, _oldPoint1.Y, _oldPoint2.X, _oldPoint2.Y, _oldPoint3.X, _oldPoint3.Y);
        
        _triangle.FillColor = _oldFill;
        _triangle.BorderColor = _oldBorder;
    }
}