namespace ShapesProject.Utils.Commands.Core;

public interface ICommand
{
    void Execute();
    void Undo();
    void Redo();
}