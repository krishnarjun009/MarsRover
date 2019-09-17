using NUnit.Framework;

namespace MarsRoverPuzzle.Tests
{
    public class TestMarsRover
    {
        [Test]
        public void Test_GetCurrentLocation()
        {
            var plateau = new Plateau(5, 5);
            var coordinate = new Coordinate(3, 3);
            var direction = DirectionMap.GetDirection('N');
            var rover = new MarsRover(plateau, coordinate, direction);

            Assert.AreEqual("3 3 N", rover.GetCurrentLocation());
        }

        [Test]
        public void Test_TurnLeft()
        {
            var plateau = new Plateau(5, 5);
            var coordinate = new Coordinate(1, 2);
            var direction = DirectionMap.GetDirection('N');
            var rover = new MarsRover(plateau, coordinate, direction);

            rover.TurnLeft();

            Assert.AreEqual("1 2 W", rover.GetCurrentLocation());
        }

        [Test]
        public void Test_TurnRight()
        {
            var plateau = new Plateau(5, 5);
            var coordinate = new Coordinate(1, 2);
            var direction = DirectionMap.GetDirection('N');
            var rover = new MarsRover(plateau, coordinate, direction);

            rover.TurnRight();

            Assert.AreEqual("1 2 E", rover.GetCurrentLocation());
        }

        [Test]
        public void Test_Move()
        {
            var plateau = new Plateau(5, 5);
            var coordinate = new Coordinate(1, 2);
            var direction = DirectionMap.GetDirection('N');
            var rover = new MarsRover(plateau, coordinate, direction);

            rover.Move();

            Assert.AreEqual("1 3 N", rover.GetCurrentLocation());
        }

        [Test]
        public void Test_Run()
        {
            var plateau = new Plateau(5, 5);
            var coordinate = new Coordinate(1, 2);
            var direction = DirectionMap.GetDirection('N');
            var rover = new MarsRover(plateau, coordinate, direction);

            string command = "M";

            rover.Run(command);

            Assert.AreEqual("1 3 N", rover.GetCurrentLocation());
        }

        [Test]
        public void Test_Run_Multiple_Commands()
        {
            var plateau = new Plateau(5, 5);
            var coordinate = new Coordinate(1, 2);
            var direction = DirectionMap.GetDirection('N');
            var rover = new MarsRover(plateau, coordinate, direction);

            string command = "LMLMLMLMM";

            rover.Run(command);

            Assert.AreEqual("1 3 N", rover.GetCurrentLocation());
        }

        [Test]
        public void Test_WontDriveOffPlateau()
        {
            var plateau = new Plateau(5, 5  );
            var coordinate = new Coordinate(0, 4);
            var direction = DirectionMap.GetDirection('N');
            var rover = new MarsRover(plateau, coordinate, direction);

            string command = "RM";

            rover.Run(command);
            
            Assert.AreEqual("1 4 E", rover.GetCurrentLocation());
        }
    }
}
