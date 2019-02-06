using MassRover.Core.Contracts;
using MassRover.Core.Model;

namespace MassRover.Core.Model
{
    public abstract class Direction : IDirection
    {
        public abstract string Name { get; }
        private Direction _left;
        private Direction _right;
        public void SetLeftAndRight(Direction directionToLeft, Direction directionToRight)
        {
            _left = directionToLeft;
            _right = directionToRight;
        }
        public Direction GetLeftDirection() => _left;
        public Direction GetRightDirection() => _right;
        public abstract Position GetPositionChange(double stepSize);
    }
}
