
namespace MarsRoverPuzzle
{
    public abstract class Direction
    {
        public int x { get; }
        public int y { get; }
        public char head { get; }

        public Direction(int x, int y, char head)
        {
            this.x = x;
            this.y = y;
            this.head = char.ToUpper(head);
        }

        public abstract Direction TurnLeft();
        public abstract Direction TurnRight();
    }

    public class North : Direction
    {
        public North() : base(0, 1, 'N') { }

        public override Direction TurnRight() => new East();
        public override Direction TurnLeft() => new West();
    }

    public class West : Direction
    {
        public West() : base(-1, 0, 'W') { }

        public override Direction TurnRight() => new North();
        public override Direction TurnLeft() => new South();
    }

    public class East : Direction
    {
        public East() : base(1, 0, 'E') { }

        public override Direction TurnRight() => new South();
        public override Direction TurnLeft() => new North();
    }

    public class South : Direction
    {
        public South() : base(0, -1, 'S') { }

        public override Direction TurnRight() => new West();
        public override Direction TurnLeft() => new East();
    }
}
