using MassRover.Core.Model;

namespace MassRover.Core.Contracts
{
    public interface ICommandExecuter
    {
        Position Execute(Position position, Command command, Canvas canvas);
    }
}
