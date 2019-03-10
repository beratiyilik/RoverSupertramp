namespace RoverSupertramp
{
    interface IMovement
    {
        void Move(Position roverPosition);
    }

    public class Forward : IMovement
    {
        public void Move(Position roverPosition)
        {
            switch (roverPosition.Direction)
            {
                case CardinalDirection.North:
                    roverPosition.Coordinate.Y++;
                    break;
                case CardinalDirection.East:
                    roverPosition.Coordinate.X++;
                    break;
                case CardinalDirection.South:
                    roverPosition.Coordinate.Y--;
                    break;
                case CardinalDirection.West:
                    roverPosition.Coordinate.X--;
                    break;
                default:
                    break;
            }
        }
    }

    public class Right : IMovement
    {
        public void Move(Position roverPosition)
        {
            switch (roverPosition.Direction)
            {
                case CardinalDirection.North:
                    roverPosition.Direction = CardinalDirection.East;
                    break;
                case CardinalDirection.East:
                    roverPosition.Direction = CardinalDirection.South;
                    break;
                case CardinalDirection.South:
                    roverPosition.Direction = CardinalDirection.West;
                    break;
                case CardinalDirection.West:
                    roverPosition.Direction = CardinalDirection.North;
                    break;
                default:
                    break;
            }
        }
    }

    public class Left : IMovement
    {
        public void Move(Position roverPosition)
        {
            switch (roverPosition.Direction)
            {
                case CardinalDirection.North:
                    roverPosition.Direction = CardinalDirection.West;
                    break;
                case CardinalDirection.East:
                    roverPosition.Direction = CardinalDirection.North;
                    break;
                case CardinalDirection.South:
                    roverPosition.Direction = CardinalDirection.East;
                    break;
                case CardinalDirection.West:
                    roverPosition.Direction = CardinalDirection.South;
                    break;
                default:
                    break;
            }
        }
    }
}
