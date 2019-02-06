using MassRover.Core.Contracts;

namespace MassRover.Core.Model
{
    public class FourDirectionLink : ILink
    {
        public void CreateLink()
        {
            North.Instance.SetLeftAndRight(West.Instance, East.Instance);
            East.Instance.SetLeftAndRight(North.Instance, South.Instance);
            South.Instance.SetLeftAndRight(East.Instance, West.Instance);
            West.Instance.SetLeftAndRight(South.Instance, North.Instance);
            NorthEast.Instance.SetLeftAndRight(NorthWest.Instance, SouthEast.Instance);
            NorthWest.Instance.SetLeftAndRight(SouthWest.Instance, NorthEast.Instance);
            SouthEast.Instance.SetLeftAndRight(NorthEast.Instance, SouthWest.Instance);
            SouthWest.Instance.SetLeftAndRight(SouthEast.Instance, NorthEast.Instance);
        }
    }
}
