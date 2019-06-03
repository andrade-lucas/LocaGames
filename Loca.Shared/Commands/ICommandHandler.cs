namespace Loca.Shared.Commands
{
    public interface ICommandHandler<Command> where Command : ICommand
    {
        ICommandResult Handler(ICommand command);
    }
}
