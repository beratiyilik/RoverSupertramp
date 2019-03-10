using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace RoverSupertramp
{
    class Program
    {
        private static Hashtable ht = new Hashtable()
                {
                    { "M", new Forward() },
                    { "L", new Left()},
                    { "R", new Right()},
                    { "N", CardinalDirection.North},
                    { "E", CardinalDirection.East},
                    { "S", CardinalDirection.South},
                    { "W", CardinalDirection.West}
                };

        static void Main(string[] args)
        {
            Invoker invoker = new Invoker();
            string[] commandList = getCommandsAsString().Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            for (int i = 0; i < commandList.Length; i++)
            {
                if (i == 0)
                {
                    string[] commandPostions = commandList[i].Split(' ');
                    if (commandPostions.Length == 2)
                        invoker.SetPlateauSize(new Coordinate(Convert.ToInt32(commandPostions[0]), Convert.ToInt32(commandPostions[1])));
                }
                else if (i % 2 == 1)
                {
                    string[] commandPostions = commandList[i].Split(' ');
                    if (commandPostions.Length == 3)
                        invoker.SetStartPoint(new Position(Convert.ToInt32(commandPostions[0]),
                                                           Convert.ToInt32(commandPostions[1]),
                                                           (CardinalDirection)ht[commandPostions[2]]));
                }
                else
                {
                    invoker.ExecuteCommand(commandList[i].Select(m => (IMovement)ht[m.ToString()]).ToArray());
                    Console.WriteLine(invoker.GetCurrentRoverPosition().Coordinate.X + " " +
                                      invoker.GetCurrentRoverPosition().Coordinate.Y + " " +
                                      invoker.GetCurrentRoverPosition().Direction.ToString().FirstOrDefault());
                }
            }

            Console.ReadKey();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private static string getCommandsAsString()
        {
            var builder = new StringBuilder();
            builder.AppendLine("5 5");
            builder.AppendLine("1 2 N");
            builder.AppendLine("LMLMLMLMM");
            builder.AppendLine("3 3 E");
            builder.Append("MMRMMRMRRM");

            return builder.ToString();
        }
    }
}
