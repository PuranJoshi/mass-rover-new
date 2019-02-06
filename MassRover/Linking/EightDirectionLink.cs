using MassRover.Core.Contracts;

namespace MassRover.Core.Model
{
    public class EightDirectionLink : ILink
    {
        public void CreateLink()
        {
            North.Instance.SetLeftAndRight(NorthWest.Instance, NorthEast.Instance);
            NorthEast.Instance.SetLeftAndRight(North.Instance, East.Instance);
            East.Instance.SetLeftAndRight(NorthEast.Instance, SouthEast.Instance);
            SouthEast.Instance.SetLeftAndRight(East.Instance, South.Instance);
            South.Instance.SetLeftAndRight(SouthEast.Instance, SouthWest.Instance);
            SouthWest.Instance.SetLeftAndRight(South.Instance, West.Instance);
            West.Instance.SetLeftAndRight(SouthWest.Instance, NorthWest.Instance);
            NorthWest.Instance.SetLeftAndRight(West.Instance, North.Instance);
        }
    }
}
