
namespace MarsRoverPuzzle
{
    public class Plateau
    {
        private readonly Coordinate topRightCoordinate;
        private readonly Coordinate bottomLeftCoordinate;

        public Plateau(int topRightXCoordinate, int topRightYCoordinate)
        {
            this.topRightCoordinate = new Coordinate(topRightXCoordinate, topRightYCoordinate);
            this.bottomLeftCoordinate = new Coordinate(0, 0);
        }

        public Plateau(Coordinate topRightCoordinate)
        {
            this.topRightCoordinate = topRightCoordinate;
            this.bottomLeftCoordinate = new Coordinate(0, 0);
        }

        public bool HasWithinBounds(Coordinate coordinate) => 
            bottomLeftCoordinate.HasOutSideBounds(coordinate) && topRightCoordinate.HasWithinBounds(coordinate);
    }
}
