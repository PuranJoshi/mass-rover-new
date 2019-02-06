using MassRover.Core.Contracts;
using MassRover.Core.Model;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("MassRover.Tests")]
namespace MassRover.Core
{
    public class MassRoverInSpace : Movable
    {
        public MassRoverInSpace(Position position) : base(position, null)
        {
        }

        internal MassRoverInSpace(Position position, ICommandExecuter commandExecuter, ILink directionLink) 
            : base(position, null, commandExecuter, directionLink)
        {
        }
    }
}
