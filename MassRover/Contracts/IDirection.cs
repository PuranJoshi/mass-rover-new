using MassRover.Core.Model;

namespace MassRover.Core.Contracts
{
    public interface IDirection
    {
        Position GetPositionChange(double stepSize);
        Direction GetLeftDirection();
        Direction GetRightDirection();
    }
}
