﻿using MarsRoverPuzzle.Commands;
using NUnit.Framework;

namespace MarsRoverPuzzle.Tests.Commands
{
    public class TestMoveCommand
    {
        [Test]
        public void Test_MoveCommand()
        {
            var plateau = new Plateau(5, 5);
            var coordinate = new Coordinate(1, 2);
            var direction = DirectionParser.GetDirection('N');
            var rover = new MarsRover(plateau, coordinate, direction);

            var moveCommand = new MoveCommand();

            moveCommand.Execute(rover);

            Assert.AreEqual("1 3 N", rover.GetCurrentLocation());
        }
    }
}
