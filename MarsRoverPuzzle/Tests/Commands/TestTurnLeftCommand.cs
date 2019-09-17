using MarsRoverPuzzle.Commands;
using NUnit.Framework;

namespace MarsRoverPuzzle.Tests.Commands
{
    public class TestTurnLeftCommand
    {
        [Test]
        public void Test_TurnLeftCommand()
        {
            var plateau = new Plateau(5, 5);
            var coordinate = new Coordinate(1, 2);
            var direction = DirectionParser.GetDirection('N');
            var rover = new MarsRover(plateau, coordinate, direction);

            var moveCommand = new TurnLeftCommand();

            moveCommand.Execute(rover);

            Assert.AreEqual("1 2 W", rover.GetCurrentLocation());
        }
    }
}
