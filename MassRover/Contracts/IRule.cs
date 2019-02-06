using MassRover.Core.Model;

namespace MassRover.Core.Contracts
{
    public interface IRule
    {
        bool IsValidMove(Canvas canvas, Position position);
    }
}
