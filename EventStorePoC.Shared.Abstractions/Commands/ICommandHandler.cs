

namespace EventStorePoC.Shared.Abstractions.Commands;
public interface ICommandHandler<in TCommand> where TCommand : class, ICommand
{
    Task HandlerAsync(TCommand command);    
}
