using System.Collections.Generic;

namespace MarsRoverPuzzle.Commands
{
    public class CommandParser
    {
        private static Dictionary<char, ICommand<IRover>> commandMap = new Dictionary<char, ICommand<IRover>>()
        {
            {'L', new TurnLeftCommand()},
            {'R', new TurnRightCommand()},
            {'M', new MoveCommand()}
        };

        private readonly string command;

        public CommandParser(string command) => this.command = command;

        public List<ICommand<IRover>> ToCommands()
        {
            var commandsList = new List<ICommand<IRover>>();
            char[] commands = command.ToUpper().ToCharArray();
            foreach(var command in commands)
            {
                var outputCommand = GetCommand(command);
                if (outputCommand == null) break;
                commandsList.Add(outputCommand);
            }
            return commandsList;
        }

        private ICommand<IRover> GetCommand(char command)
        {
            commandMap.TryGetValue(command, out ICommand<IRover> commandToExecute);
            return commandToExecute;
        }
    }
}
