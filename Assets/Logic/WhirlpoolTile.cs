namespace Logic
{

public class WhirlpoolTile: Tile
{
    public WhirlpoolTile()
    {
    }

    public void Enter(Ship ship)
    {
        ship.Rotate(turnType: TurnType.Uturn);
    }

    public void Leave()
    {
    }
}

}