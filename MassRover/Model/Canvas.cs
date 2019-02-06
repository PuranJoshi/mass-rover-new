using MassRover.Core.Contracts;

namespace MassRover.Core.Model
{
    public class Canvas
    {
        private readonly double _length;
        private readonly double _breath;
        public Canvas(double length, double breath)
        {
            _length = length;
            _breath = breath;
        }
        public double XMax => _length / 2;
        public double XMin => -_length / 2;
        public double YMax => _breath / 2;
        public double YMin => -_breath / 2;
    }
}
