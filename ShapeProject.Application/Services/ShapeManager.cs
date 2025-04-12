using ShapeProject.Application.Commands.Core;
using ShapeProject.Application.Commands.Selection;
using ShapesProject.Domain.Shapes;

namespace ShapeProject.Application.Services;

public class ShapeManager
{
    private readonly List<Shape> _shapes = new();
    public Shape? SelectedShape => _shapes.FirstOrDefault(s => s.IsSelected);

    private readonly Stack<ICommand> _undoStack = new();
    private readonly Stack<ICommand> _redoStack = new();

    public event EventHandler? CommandExecuted;

    public IReadOnlyList<Shape> GetShapes() => _shapes.AsReadOnly();

    public void ExecuteCommand(ICommand command)
    {
        command.Execute();

        _undoStack.Push(command);
        _redoStack.Clear();

        OnCommandExecuted();
    }

    public void Undo()
    {
        if (_undoStack.Count == 0)
        {
            return;
        }

        var command = _undoStack.Pop();
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
        _undoStack.Push(command);

        OnCommandExecuted();
    }

    private void OnCommandExecuted() => CommandExecuted?.Invoke(this, EventArgs.Empty);

    internal void AddShape(Shape shape)
    {
        _shapes.Add(shape);
    }

    internal void DeleteShape(Shape shape)
    {
        _shapes.Remove(shape);
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