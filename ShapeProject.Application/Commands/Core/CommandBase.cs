namespace ShapeProject.Application.Commands.Core;

public abstract class CommandBase : ICommand
{
    public abstract void Execute();
    public abstract void Undo();

    public virtual void Redo() => Execute();

    protected static void EnsureState(bool condition, string message)
    {
        if (!condition)
        {
            throw new InvalidOperationException(message);
        }
    }
}