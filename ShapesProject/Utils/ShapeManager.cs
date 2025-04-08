using ShapesProject.Models;
using ShapesProject.Utils.Commands;

namespace ShapesProject.Utils;

public class ShapeManager
{
    private readonly List<Shape> _shapes = new();
    public Shape? SelectedShape => _shapes.FirstOrDefault(s => s.IsSelected);

    private readonly Stack<ICommand> _commandHistory = new();
    private readonly Stack<ICommand> _redoStack = new();

    public event EventHandler? CommandExecuted;
    public event EventHandler<ShapeEventArgs>? SelectionChanged;
    public event EventHandler<ShapeEventArgs>? ShapeAdded;
    public event EventHandler<ShapeEventArgs>? ShapeDeleted;

    public IReadOnlyList<Shape> GetShapes() => _shapes.AsReadOnly();

    public void ExecuteCommand(ICommand command)
    {
        command.Execute();

        _commandHistory.Push(command);
        _redoStack.Clear();

        if (SelectedShape != null)
        {
            OnSelectionChanged(SelectedShape);
        }

        CommandExecuted?.Invoke(this, EventArgs.Empty);
    }

    public void Undo()
    {
        if (_commandHistory.Count == 0)
        {
            return;
        }

        var command = _commandHistory.Pop();
        command.Undo();

        _redoStack.Push(command);
        
        OnCommandExecuted();
    }

    public void Redo()
    {
        if (_redoStack.Count == 0)
        {
            return;
        }

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

    private void OnSelectionChanged(Shape shape)
    {
        SelectionChanged?.Invoke(this, new ShapeEventArgs(shape));
    }

    public void ClearSelection()
    {
        var commands = _shapes
            .Where(s => s.IsSelected)
            .Select(s => new SelectCommand(s, false))
            .ToList();

        if (commands.Count > 0)
        {
            ExecuteCommand(new BatchCommand(commands));
        }
    }
}