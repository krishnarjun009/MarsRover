using NUnit.Framework;

namespace MarsRoverPuzzle.Tests
{
    public class TestDirection
    {
        [Test]
        public void Test_North_Valid_Initialization()
        {
            var direction = new North();

            Assert.AreEqual("0 1 N", direction.GetDirectionAsString());
        }

        [Test]
        public void Test_North_TurnLeft()
        {
            var direction = new North();

            var left = direction.TurnLeft();

            Assert.AreEqual("-1 0 W", left.GetDirectionAsString());
        }

        [Test]
        public void Test_North_TurnRight()
        {
            var direction = new North();

            var right = direction.TurnRight();

            Assert.AreEqual("1 0 E", right.GetDirectionAsString());
        }

        [Test]
        public void Test_South_Valid_Initialization()
        {
            var direction = new South();

            Assert.AreEqual("0 -1 S", direction.GetDirectionAsString());
        }

        [Test]
        public void Test_South_TurnLeft()
        {
            var direction = new South();

            var left = direction.TurnLeft();

            Assert.AreEqual("1 0 E", left.GetDirectionAsString());
        }

        [Test]
        public void Test_South_TurnRight()
        {
            var direction = new South();

            var right = direction.TurnRight();

            Assert.AreEqual("-1 0 W", right.GetDirectionAsString());
        }

        [Test]
        public void Test_West_Valid_Initialization()
        {
            var direction = new West();

            Assert.AreEqual("-1 0 W", direction.GetDirectionAsString());
        }

        [Test]
        public void Test_West_TurnLeft()
        {
            var direction = new West();

            var left = direction.TurnLeft();

            Assert.AreEqual("0 -1 S", left.GetDirectionAsString());
        }

        [Test]
        public void Test_West_TurnRight()
        {
            var direction = new West();

            var right = direction.TurnRight();

            Assert.AreEqual("0 1 N", right.GetDirectionAsString());
        }

        [Test]
        public void Test_East_Valid_Initialization()
        {
            var direction = new East();

            Assert.AreEqual("1 0 E", direction.GetDirectionAsString());
        }

        [Test]
        public void Test_East_TurnLeft()
        {
            var direction = new East();

            var left = direction.TurnLeft();

            Assert.AreEqual("0 1 N", left.GetDirectionAsString());
        }

        [Test]
        public void Test_East_TurnRight()
        {
            var direction = new East();

            var right = direction.TurnRight();

            Assert.AreEqual("0 -1 S", right.GetDirectionAsString());
        }
    }
}
