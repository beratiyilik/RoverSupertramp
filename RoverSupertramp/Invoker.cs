using System.Collections.Generic;

namespace RoverSupertramp
{
    class Invoker
    {
        private Coordinate _plateauSize;
        private Rover _rover = new Rover();
        private List<Command> _commands = new List<Command>();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="position"></param>
        public void SetStartPoint(Position position)
        {
            this._rover.Position = position;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Position GetCurrentRoverPosition()
        {
            return _rover.Position;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="plateauSize"></param>
        public void SetPlateauSize( Coordinate plateauSize)
        {
            this._plateauSize = plateauSize;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="movement"></param>
        public void ExecuteCommand(IMovement movement)
        {
            Command command = new RoverCommand(_rover, movement);
            command.Execute();

            this._commands.Add(command);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="movements"></param>
        public void ExecuteCommand(IEnumerable<IMovement> movements)
        {
            foreach (var movement in movements)
            {
                this.ExecuteCommand(movement);
            }
        }
    }
}
