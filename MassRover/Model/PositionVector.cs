using MassRover.Core.Contracts;

namespace MassRover.Core.Model
{
    public class PositionVector : Position
    {
        public string Facing => Direction.Name;
        internal readonly Direction Direction;
        public PositionVector(double x, double y, Direction direction) : base(x, y)
        {
            Direction = direction;
        }
    }
}
