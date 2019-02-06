using MassRover.Core.Model;

namespace MassRover.Core.Model
{
    internal class SouthEast : Direction
    {
        private static SouthEast _instance = new SouthEast();
        static SouthEast() { }
        public static Direction Instance => _instance;
        public override string Name => Constants.Direction.SouthEast;
        public override Position GetPositionChange(double stepSize) => new Position(stepSize, -stepSize);
    }
}
