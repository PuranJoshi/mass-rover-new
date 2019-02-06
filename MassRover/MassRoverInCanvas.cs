using MassRover.Core.Contracts;
using MassRover.Core.Model;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("MassRover.Tests")]
namespace MassRover.Core
{
    class MassRoverInCanvas : Movable
    {
        public MassRoverInCanvas(Position position, Canvas canvas) : base(position, canvas)
        {
        }

        internal MassRoverInCanvas(Position position, Canvas canvas, ICommandExecuter commandExecuter, ILink directionLink)
            : base(position, canvas, commandExecuter, directionLink)
        {
        }
    }
}
