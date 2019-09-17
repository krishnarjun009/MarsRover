using MarsRoverPuzzle.Commands;

namespace MarsRoverPuzzle
{
    public interface IRover
    {
        void Run(string commandString);
        void TurnRight();
        void TurnLeft();
        void Move();
        string GetCurrentLocation();
    }

    public class MarsRover : IRover
    {
        private Plateau plateau;
        private Coordinate currentCoordinate;
        private Direction currentDirection;

        public MarsRover(Plateau plateau, Coordinate currentCoordinate, Direction currentDirection)
        {
            this.plateau = plateau;
            this.currentCoordinate = currentCoordinate;
            this.currentDirection = currentDirection;
        }        

        public void Run(string commandString)
        {
            var commands = new CommandParser(commandString).ToCommands();
            foreach (var command in commands)
                command.Execute(this);            
        }

        public void TurnLeft() => this.currentDirection = this.currentDirection.TurnLeft();
        public void TurnRight() => this.currentDirection = this.currentDirection.TurnRight();

        public string GetCurrentLocation() => this.ToString();

        public override string ToString()
        {
            var builder = new System.Text.StringBuilder();
            builder.Append(currentCoordinate.x)
                    .Append(" ")
                    .Append(currentCoordinate.y)
                    .Append(" ")
                    .Append(currentDirection.head);
            return builder.ToString();
        }

        public void Move()
        {
            var positionAfterMove = this.currentCoordinate.GetNewCoordinate(currentDirection.x, currentDirection.y);
            if(this.plateau.HasWithinBounds(positionAfterMove))
                this.currentCoordinate = positionAfterMove;
        }
    }
}
