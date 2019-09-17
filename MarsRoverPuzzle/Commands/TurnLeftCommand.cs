
namespace MarsRoverPuzzle.Commands
{
    public class TurnLeftCommand : ICommand<IRover>
    {
        public void Execute(IRover target) => target.TurnLeft();
    }
}
