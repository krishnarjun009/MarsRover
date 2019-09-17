using System.Collections.Generic;

namespace MarsRoverPuzzle
{
    public sealed class DirectionMap
    {
        private static readonly Dictionary<char, Direction> directionMap = new Dictionary<char, Direction>()
        {
            {'N', new North()},
            {'S', new South()},
            {'W', new West()},
            {'E', new East()}
        };

        public static Direction GetDirection(char directionKey) => GetDirectionMapValue(directionKey);

        private static Direction GetDirectionMapValue(char key)
        {
            directionMap.TryGetValue(char.ToUpper(key), out Direction commandToExecute);
            return commandToExecute;
        }
    }
}
