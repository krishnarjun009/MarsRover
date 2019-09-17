using System;
using System.Collections.Generic;

namespace MarsRoverPuzzle
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Bottom Right Coordinates: ");
            var input = Console.ReadLine();
            string[] tokens = input.Split(' ');

            int.TryParse(tokens[0], out int a);
            int.TryParse(tokens[1], out int b);

            Console.Write("Enter no of Rovers / Sqaud: ");
            int count = int.Parse(Console.ReadLine());

            var roversList = new List<IRover>();
            var commands = new List<string>();

            for(int i = 0; i < count; i++)
            {
                Console.Write("Enter Rover Position and Facing Direction: ");
                input = Console.ReadLine();
                tokens = input.Split(' ');

                int.TryParse(tokens[0], out int x);
                int.TryParse(tokens[1], out int y);
                string facingDirection = tokens[2];

                Console.Write("Enter Command: ");
                string command = Console.ReadLine();
                roversList.Add(new MarsRover(new Plateau(a, b), new Coordinate(x, y),
                               DirectionParser.GetDirection(char.Parse(facingDirection))));
                commands.Add(command);
            }
            
            for(int i = 0; i < roversList.Count; i++)
                roversList[i].Run(commands[i]);

            //var deployer = new RoversDeployer();
            //foreach (var rover in roversList)
            //    deployer.AddRover(rover);
            //deployer.Deploy();

            Console.WriteLine("================== Output ===================");

            foreach(var rover in roversList)
            {
                Console.WriteLine(rover.ToString());
                Console.WriteLine("=====================================");
            }
        }
    }
}
