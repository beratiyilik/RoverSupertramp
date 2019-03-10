namespace RoverSupertramp
{
    class Rover
    {
        public Position Position { get; set; }

        private IMovement _movement;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="movement"></param>
        public void Action(IMovement movement)
        {
            //Console.Write("(" + this.Position.Coordinate.X + "," + this.Position.Coordinate.Y + ")," + this.Position.Direction);
            this._movement = movement;
            this._movement.Move(this.Position);
            //Console.Write(" Move : " + _movement.GetType().Name + " =>");
            //Console.WriteLine(" (" + this.Position.Coordinate.X + "," + this.Position.Coordinate.Y + ")," + this.Position.Direction);
        }
    }
}
