using MassRover.Core.Contracts;

namespace MassRover.Core.Model
{
    public class Position
    {
        public Position(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; private set; }
        public double Y { get; private set; }
    }
}
