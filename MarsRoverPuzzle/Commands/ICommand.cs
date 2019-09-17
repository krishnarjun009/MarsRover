namespace MarsRoverPuzzle.Commands
{
    public interface ICommand<T>
    {
        void Execute(T target);
    }
}
