using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("MassRover.Tests")]
namespace MassRover.Core
{
    internal static class Constants
    {
        internal static class Direction
        {
            internal const string North = "North";
            internal const string East = "East";
            internal const string South = "South";
            internal const string West = "West";

            internal const string NorthEast = "NorthEast";
            internal const string NorthWest = "NorthWest";
            internal const string SouthEast = "SouthEast";
            internal const string SouthWest = "SouthWest";
        }
    }
}
