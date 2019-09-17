using NUnit.Framework;

namespace MarsRoverPuzzle.Tests
{
    public class TestPlateau
    {
        [Test]
        public void Test_HasWithinBounds()
        {
            var plateau = new Plateau(5, 5);

            var point = new Coordinate(0, 5);

            Assert.IsTrue(plateau.HasWithinBounds(point));
        }

        [Test]
        public void Test_Has_X_OutOfMinBound()
        {
            var plateau = new Plateau(5, 5);

            var point = new Coordinate(-1, 5);

            Assert.IsFalse(plateau.HasWithinBounds(point));
        }

        [Test]
        public void Test_Has_Y_OutOfMinBound()
        {
            var plateau = new Plateau(5, 5);

            var point = new Coordinate(1, -1);

            Assert.IsFalse(plateau.HasWithinBounds(point));
        }

        [Test]
        public void Test_Has_X_OutOfMaxBound()
        {
            var plateau = new Plateau(5, 5);

            var point = new Coordinate(9, 5);

            Assert.IsFalse(plateau.HasWithinBounds(point));
        }

        [Test]
        public void Test_Has_Y_OutOfMaxBound()
        {
            var plateau = new Plateau(5, 5);

            var point = new Coordinate(1, 7);

            Assert.IsFalse(plateau.HasWithinBounds(point));
        }
    }
}
