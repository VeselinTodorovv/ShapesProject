using System.Drawing;
using ShapesProject.Domain;
using ShapesProject.Domain.Primitives;
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
        
        var newFillColor = new CustomColor(_newFill.A, _newFill.R, _newFill.G, _newFill.B);
        var newBorderColor = new CustomColor(_newBorder.A, _newBorder.R, _newBorder.G, _newBorder.B);
        
        _parallelogram.FillColor = newFillColor;
        _parallelogram.BorderColor = newBorderColor;
    }
    public override void Undo()
    {
        _parallelogram.EditSize(_oldBase, _oldHeight, _oldSide);
        
        var oldFillColor = new CustomColor(_oldFill.A, _oldFill.R, _oldFill.G, _oldFill.B);
        var oldBorderColor = new CustomColor(_oldBorder.A, _oldBorder.R, _oldBorder.G, _oldBorder.B);
        
        _parallelogram.FillColor = oldFillColor;
        _parallelogram.BorderColor = oldBorderColor;
    }
}