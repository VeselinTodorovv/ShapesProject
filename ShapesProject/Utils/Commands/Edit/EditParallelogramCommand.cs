using ShapesProject.Models;
using ShapesProject.Utils.Commands.Core;

namespace ShapesProject.Utils.Commands.Edit;

internal class EditParallelogramCommand : CommandBase
{
    private readonly Shape _parallelogram;
    
    private readonly int _oldBase;
    private readonly int _newBase;
    
    private readonly int _oldHeight;
    private readonly int _newHeight;
    
    private readonly int _oldSide;
    private readonly int _newSide;
    
    private readonly Color _oldFill;
    private readonly Color _newFill;
    
    private readonly Color _oldBorder;
    private readonly Color _newBorder;

    public EditParallelogramCommand(Parallelogram parallelogram, int oldBase, int newBase, int oldHeight, int newHeight, int oldSide, int newSide,
        Color oldFill, Color newFill, Color oldBorder, Color newBorder)
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