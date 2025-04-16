using ShapeProject.Application.Commands.Core;
using ShapesProject.Domain.Primitives;
using ShapesProject.Domain.Shapes;

namespace ShapeProject.Application.Commands.Edit;

public class EditParallelogramCommand : CommandBase
{
    private readonly Shape _parallelogram;
    
    private readonly int _oldBase, _newBase;
    private readonly int _oldHeight, _newHeight;
    private readonly int _oldSide, _newSide;
    
    private readonly CustomColor _oldFill, _newFill;
    private readonly CustomColor _oldBorder, _newBorder;

    public EditParallelogramCommand(Parallelogram parallelogram, int oldBase, int newBase, int oldHeight, int newHeight, int oldSide, int newSide,
        CustomColor oldFill, CustomColor newFill, CustomColor oldBorder, CustomColor newBorder)
    {
        _parallelogram = parallelogram
            ?? throw new ArgumentNullException(nameof(parallelogram));
        
        _oldBase = oldBase;
        _newBase = newBase;
        
        _oldHeight = oldHeight;
        _newHeight = newHeight;
        
        _oldSide = oldSide;
        _newSide = newSide;
        
        _oldFill = oldFill;
        _newFill = newFill;
        
        _oldBorder = oldBorder;
        _newBorder = newBorder;
    }

    public override void Execute()
    {
        _parallelogram.EditSize(_newBase, _newHeight, _newSide);
        
        _parallelogram.FillColor = _newFill;
        _parallelogram.BorderColor = _newBorder;
    }
    
    public override void Undo()
    {
        _parallelogram.EditSize(_oldBase, _oldHeight, _oldSide);
        
        _parallelogram.FillColor = _oldFill;
        _parallelogram.BorderColor = _oldBorder;
    }
}