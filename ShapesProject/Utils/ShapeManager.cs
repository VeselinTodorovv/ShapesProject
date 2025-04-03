using ShapesProject.Models;
using ShapesProject.Utils.Commands;

namespace ShapesProject.Utils;

public class ShapeManager
{
    private readonly List<Shape> _shapes = new();
    private Shape? _selectedShape;

    private readonly Stack<ICommand> _commandHistory = new();
    private readonly Stack<ICommand> _redoStack = new();

    public event EventHandler CommandExecuted;
    public event EventHandler<ShapeEventArgs>? ShapeSelected;
    public event EventHandler<ShapeEventArgs>? ShapeMoved;
    public event EventHandler<ShapeEventArgs>? ShapeAdded;
    public event EventHandler<ShapeEventArgs>? ShapeDeleted;

    public IReadOnlyList<Shape> GetShapes() => _shapes.AsReadOnly();

    public void ExecuteCommand(ICommand command)
    {
        command.Execute();
        _commandHistory.Push(command);
        _redoStack.Clear();
        OnCommandExecuted();
    }

    public void Undo()
    {
        if (_commandHistory.Count == 0) return;

        var command = _commandHistory.Pop();
        command.Undo();
        _redoStack.Push(command);
        OnCommandExecuted();
    }

    public void Redo()
    {
        if (_redoStack.Count == 0) return;

        var command = _redoStack.Pop();
        command.Redo();
        _commandHistory.Push(command);
        OnCommandExecuted();
    }

    private void OnCommandExecuted() => CommandExecuted?.Invoke(this, EventArgs.Empty);

    internal void AddShape(Shape shape)
    {
        _shapes.Add(shape);
        ShapeAdded?.Invoke(this, new ShapeEventArgs(shape));
    }

    internal void DeleteShape(Shape shape)
    {
        if (_shapes.Remove(shape))
        {
            ShapeDeleted?.Invoke(this, new ShapeEventArgs(shape));
        }
    }

    public void SelectShape(Shape shape)
    {
        ShapeSelected?.Invoke(this, new ShapeEventArgs(shape));
    }

    public void MoveShape(Shape shape, int x, int y)
    {
        shape.Move(x, y);
        ShapeMoved?.Invoke(this, new ShapeEventArgs(shape));
    }

    internal void DeselectShape()
    {
        if (_selectedShape != null)
        {
            var deselectedShape = _selectedShape;
            _selectedShape = null;

            ShapeSelected?.Invoke(this, new ShapeEventArgs(deselectedShape));
        }
    }
}