using NUnit.Framework;

namespace MarsRoverPuzzle.Tests
{
    public class TestCoordinate
    {
        [Test]
        public void Test_X_Coordinate_Decremented()
        {
            var coordinate = new Coordinate(1, 1);

            coordinate = coordinate.GetNewCoordinate(-1, 0);

            Assert.AreEqual(0, coordinate.x);
        }

        [Test]
        public void Test_X_Coordinate_Incremented()
        {
            var coordinate = new Coordinate(1, 0);

            coordinate = coordinate.GetNewCoordinate(1, 1);

            Assert.AreEqual(2, coordinate.x);
        }

        [Test]
        public void Test_Y_Coordinate_Decremented()
        {
            var coordinate = new Coordinate(1, 1);

            coordinate = coordinate.GetNewCoordinate(0, -1);

            Assert.AreEqual(0, coordinate.y);
        }

        [Test]
        public void Test_Y_Coordinate_Incremented()
        {
            var coordinate = new Coordinate(1, 0);

            coordinate = coordinate.GetNewCoordinate(0, 1);

            Assert.AreEqual(1, coordinate.y);
        }

        [Test]
        public void Test_Has_Upper_Outside_Boundaries_Identified()
        {
            var boundary = new Coordinate(5, 5);

            var point = new Coordinate(7, 7);

            Assert.IsTrue(boundary.HasOutSideBounds(point));

        }

        [Test]
        public void Test_Has_Lower_Outside_Boundaries_Identified()
        {
            var boundary = new Coordinate(0, 0);

            var point = new Coordinate(-1, -1);

            Assert.IsTrue(boundary.HasWithinBounds(point));

        }
    }
}
