public class ChinaRocket : Rocket
{
    public ChinaRocket(int lifePoints, string name, int positionX, int positionY) : base(lifePoints, name, positionX, positionY)
    {
    }

    public override void attack(int positionX, int positionY, Player attackedPlayer, int attackConfig)
    {
        base.attack(positionX, positionY, attackedPlayer, attackConfig);
    }

   
}