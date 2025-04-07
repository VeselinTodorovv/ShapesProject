namespace ShapesProject.Utils.Commands;

public interface ICommand
{
    void Execute();
    void Undo();
    void Redo();
}