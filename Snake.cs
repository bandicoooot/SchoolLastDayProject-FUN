public class Snake
{
    public Position Position { get; set; }
    public Direction Direction { get; set; }

    public Snake(Position startPos, Direction startDir)
    {
        Position = startPos;
        Direction = startDir;
    }


}
