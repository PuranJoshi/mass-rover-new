using MassRover.Core.Model;

namespace MassRover.Core.Model
{
    internal class SouthWest : Direction
    {
        private static SouthWest _instance = new SouthWest();
        static SouthWest() { }
        public static Direction Instance => _instance;
        public override string Name => Constants.Direction.SouthWest;
        public override Position GetPositionChange(double stepSize) => new Position(-stepSize, -stepSize);
    }
}
