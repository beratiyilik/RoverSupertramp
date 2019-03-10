namespace RoverSupertramp
{
    public class Position
    {
        public Coordinate Coordinate { get; set; }
        public CardinalDirection Direction { get; set; }

        public Position(int x, int y, CardinalDirection direction)
        {
            this.Coordinate = new Coordinate(x, y);
            this.Direction = direction;
        }
    }
}
