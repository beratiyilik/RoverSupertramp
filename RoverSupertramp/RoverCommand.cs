namespace RoverSupertramp
{
    class RoverCommand : Command
    {
        private IMovement _movement;
        private Rover _rover;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rover"></param>
        /// <param name="movement"></param>
        public RoverCommand(Rover rover, IMovement movement)
        {
            this._rover = rover;
            this._movement = movement;

        }

        /// <summary>
        /// 
        /// </summary>
        public override void Execute()
        {
            this._rover.Action(this._movement);
        }
    }
}
