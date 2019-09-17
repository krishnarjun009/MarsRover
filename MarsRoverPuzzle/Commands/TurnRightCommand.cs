
namespace MarsRoverPuzzle.Commands
{
    public class TurnRightCommand : ICommand<IRover>
    {
        public void Execute(IRover target) => target.TurnRight();
    }
}
