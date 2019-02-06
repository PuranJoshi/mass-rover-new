using System;
using MassRover.Core.Contracts;
using MassRover.Core.Model;

namespace MassRover.Core.Stratergy
{
    public class BasicCommandExecuter : ICommandExecuter, IRule
    {
        private readonly double _stepSize = 0;
        public BasicCommandExecuter(double stepSize)
        {
            _stepSize = stepSize;
        }

        public BasicCommandExecuter(Canvas canvas, double stepSize)
        {
            _stepSize = stepSize;
        }
        public Position Execute(Position position, Command command, Canvas canvas)
        {
            var currentPosition = position as PositionVector;
            var currentDirection = currentPosition.Direction;

            switch (command)
            {
                case Command.Left:
                    var newDirection = currentDirection.GetLeftDirection();
                    return
                        new PositionVector(currentPosition.X, currentPosition.Y, newDirection);

                case Command.Right:
                    newDirection = currentDirection.GetRightDirection();
                    return
                        new PositionVector(currentPosition.X, currentPosition.Y, newDirection);

                case Command.Forward:
                    var positionChange = currentDirection.GetPositionChange(_stepSize);
                    var newPosition = GetNewPosition(currentPosition, positionChange);
                    return IsValidMove(canvas, newPosition) ? newPosition : currentPosition;

                case Command.Backward:
                    positionChange = currentDirection.GetPositionChange(-_stepSize);
                    newPosition = GetNewPosition(currentPosition, positionChange);
                    return IsValidMove(canvas, newPosition) ? newPosition : currentPosition;

                default:
                    throw new Exception("Invalid command");
            }
        }

        public bool IsValidMove(Canvas canvas, Position position)
        {
            if (canvas == null)
                return true;
            if (position.X > canvas.XMax && position.X < canvas.XMin)
                return false;
            if (position.Y > canvas.YMax && position.Y < canvas.YMin)
                return false;
            return true;
        }

        private PositionVector GetNewPosition(PositionVector currentPosition, Position positionChange)
        {
            var newXPosition = currentPosition.X + positionChange.X;
            var newYPosition = currentPosition.Y + positionChange.Y;

            return 
                new PositionVector(newXPosition, newYPosition, currentPosition.Direction);
        }
    }
}
