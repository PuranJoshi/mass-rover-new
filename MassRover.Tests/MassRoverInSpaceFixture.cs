using MassRover.Core;
using MassRover.Core.Contracts;
using MassRover.Core.Model;
using MassRover.Core.Stratergy;
using Xunit;

namespace MassRover.Tests
{
    public class MassRoverInSpaceFixture
    {
        private MassRoverInSpace _massRover;
                
        [Theory(DisplayName = "Single Command")]
        [InlineData(Constants.Direction.East, Command.Left, 0, 0, Constants.Direction.North)]
        [InlineData(Constants.Direction.North, Command.Left, 0, 0, Constants.Direction.West)]
        [InlineData(Constants.Direction.West, Command.Left, 0, 0, Constants.Direction.South)]
        [InlineData(Constants.Direction.South, Command.Left, 0, 0, Constants.Direction.East)]
        [InlineData(Constants.Direction.East, Command.Right, 0, 0, Constants.Direction.South)]
        [InlineData(Constants.Direction.North, Command.Right, 0, 0, Constants.Direction.East)]
        [InlineData(Constants.Direction.West, Command.Right, 0, 0, Constants.Direction.North)]
        [InlineData(Constants.Direction.South, Command.Right, 0, 0, Constants.Direction.West)]
        [InlineData(Constants.Direction.East, Command.Forward, 1, 0, Constants.Direction.East)]
        [InlineData(Constants.Direction.North, Command.Forward, 0, 1, Constants.Direction.North)]
        [InlineData(Constants.Direction.West, Command.Forward, -1, 0, Constants.Direction.West)]
        [InlineData(Constants.Direction.South, Command.Forward, 0, -1, Constants.Direction.South)]
        [InlineData(Constants.Direction.East, Command.Backward, -1, 0, Constants.Direction.East)]
        [InlineData(Constants.Direction.North, Command.Backward, 0, -1, Constants.Direction.North)]
        [InlineData(Constants.Direction.West, Command.Backward, 1, 0, Constants.Direction.West)]
        [InlineData(Constants.Direction.South, Command.Backward, 0, 1, Constants.Direction.South)]
        public void FromInitialPosition_SingleCommand(string currentDirection, Command command, double x, double y, string newDirection)
        {
            #region ARRANGE
            var commandExecuter = new BasicCommandExecuter(1);
            var initialDirection = GetDirection(currentDirection);
            var initialPosition = new PositionVector(0, 0, initialDirection);
            var directionLinker = new FourDirectionLink();
            _massRover = new MassRoverInSpace(initialPosition, commandExecuter, directionLinker);
            #endregion

            #region ACT
            _massRover.ExecuteCommand(command);
            #endregion

            #region ASSERT
            Assert.Equal(x, _massRover.Position.X);
            Assert.Equal(y, _massRover.Position.Y);
            Assert.Equal(currentDirection, initialPosition.Facing);
            Assert.Equal(newDirection, (_massRover.Position as PositionVector).Facing);
            #endregion
        }

        [Fact(DisplayName = "Multiple Commands")]
        public void FromInitialPosition_MultipleCommand()
        {
            #region ARRANGE
            var commandExecuter = new BasicCommandExecuter(1);
            var initialDirection = GetDirection(Constants.Direction.East);
            var initialPosition = new PositionVector(0, 0, initialDirection);
            var directionLinker = new FourDirectionLink();
            _massRover = new MassRoverInSpace(initialPosition, commandExecuter, directionLinker);
            #endregion

            #region ACT
            _massRover.ExecuteCommand(Command.Left);
            _massRover.ExecuteCommand(Command.Left);
            _massRover.ExecuteCommand(Command.Right);
            _massRover.ExecuteCommand(Command.Forward);
            _massRover.ExecuteCommand(Command.Forward);
            _massRover.ExecuteCommand(Command.Forward);
            _massRover.ExecuteCommand(Command.Left);
            _massRover.ExecuteCommand(Command.Forward);
            _massRover.ExecuteCommand(Command.Backward);
            _massRover.ExecuteCommand(Command.Backward);
            _massRover.ExecuteCommand(Command.Right);
            #endregion

            #region ASSERT
            Assert.Equal(1, _massRover.Position.X);
            Assert.Equal(3, _massRover.Position.Y);
            Assert.Equal(Constants.Direction.East, initialPosition.Facing);
            Assert.Equal(Constants.Direction.North, (_massRover.Position as PositionVector).Facing);
            #endregion
        }

        private Direction GetDirection(string direction)
        {
            switch (direction)
            {
                case Constants.Direction.East:
                    return East.Instance;
                case Constants.Direction.North:
                    return North.Instance;
                case Constants.Direction.West:
                    return West.Instance;
                case Constants.Direction.South:
                    return South.Instance;
                case Constants.Direction.NorthEast:
                    return NorthEast.Instance;
                case Constants.Direction.NorthWest:
                    return NorthWest.Instance;
                case Constants.Direction.SouthWest:
                    return SouthWest.Instance;
                case Constants.Direction.SouthEast:
                    return SouthEast.Instance;
                default:
                    return null;

            }
        }
    }
}
