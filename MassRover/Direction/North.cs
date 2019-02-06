using MassRover.Core.Contracts;

namespace MassRover.Core.Model
{
    internal class North : Direction
    {
        private static North _instance = new North();
        static North() { }
        public static Direction Instance => _instance;
        public override string Name => Constants.Direction.North;
        public override Position GetPositionChange(double stepSize) => new Position(0, stepSize);
    }
}
