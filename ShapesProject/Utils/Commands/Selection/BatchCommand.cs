using ShapesProject.Utils.Commands.Core;

namespace ShapesProject.Utils.Commands.Selection;

class BatchCommand : ICommand
{
    private readonly List<ICommand> _commands;

    public BatchCommand(IEnumerable<ICommand> commands)
    {
        _commands = commands.ToList();
    }

    public void Execute() => _commands.ForEach(c => c.Execute());
    public void Undo() => _commands.ForEach(c => c.Undo());
    public void Redo() => Execute();
}