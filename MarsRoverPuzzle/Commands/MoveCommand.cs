namespace MarsRoverPuzzle.Commands
{
    public class MoveCommand : ICommand<IRover>
    {
        public void Execute(IRover target) => target.Move();
    }
}
