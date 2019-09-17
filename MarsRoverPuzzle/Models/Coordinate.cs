
namespace MarsRoverPuzzle
{
    public struct Coordinate
    {
        public readonly int x;
        public readonly int y;

        public Coordinate(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Coordinate GetNewCoordinate(int xStep, int yStep) => new Coordinate(x + xStep, y + yStep);

        public bool HasOutSideBounds(Coordinate coordinate) => 
            IsXCoordinateOutSideBounds(coordinate.x) && IsYCoordinateOutSideBounds(coordinate.y);

        public bool HasWithinBounds(Coordinate coordinate) => 
            IsXCoordinateWithinBounds(coordinate.x) && IsYCoordinateWithinBounds(coordinate.y);

        private bool IsXCoordinateOutSideBounds(int x) => x >= this.x;
        private bool IsYCoordinateOutSideBounds(int y) => y >= this.y;

        private bool IsXCoordinateWithinBounds(int x) => x <= this.x;
        private bool IsYCoordinateWithinBounds(int y) => y <= this.y;
    }
}
