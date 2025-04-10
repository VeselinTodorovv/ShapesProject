namespace ShapeProject.Application.Commands.Core;

public interface ICommand
{
    void Execute();
    void Undo();
    void Redo();
}