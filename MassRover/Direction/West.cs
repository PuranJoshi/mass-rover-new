using MassRover.Core.Model;

namespace MassRover.Core.Model
{
    internal class West : Direction
    {
        private static West _instance = new West();
        static West() { }
        public static Direction Instance => _instance;
        public override string Name => Constants.Direction.West;
        public override Position GetPositionChange(double stepSize) => new Position(-stepSize, 0);
    }
}
