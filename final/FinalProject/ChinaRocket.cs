public class ChinaRocket : Rocket
{
    public ChinaRocket(int lifePoints, string name, int positionX, int positionY) : base(lifePoints, name, positionX, positionY)
    {
    }

    public override void attack(int positionX, int positionY, Player attackedPlayer, int attackConfig)
    {
        //develop attack generic
        Ground attackedGround = attackedPlayer.getGround();
        //generate  other points to attack
        //China
        int x3 = positionX;
        int y3 = positionY + 1;
        int x4 = positionX;
        int y4 = positionY - 1;

        //direct attack
        for (int i = 0; i < attackedPlayer.getRocketSize(); i++)
        {

            if ((attackedPlayer.getRockets()[i].getPositionX() == positionX &&
            attackedPlayer.getRockets()[i].getPositionY() == positionY))
            {
                Console.WriteLine("Direct attack! ");

                bool statusRocket = attackedPlayer.getRockets()[i].decreaseLifePoints("direct", attackConfig);
                Console.WriteLine($"Life Points: {base.getLifePoints()}");
                if (statusRocket == false)
                {
                    attackedPlayer.getRockets().RemoveAt(i);
                }

            }
            else if ((
            (attackedPlayer.getRockets()[i].getPositionX() == x3 &&
            attackedPlayer.getRockets()[i].getPositionY() == y3) ||
            (attackedPlayer.getRockets()[i].getPositionX() == x4 &&
            attackedPlayer.getRockets()[i].getPositionY() == y4)
             ))
            {
                Console.WriteLine("Indirect attack! ");
                //decrease points of indirect attack
                attackedPlayer.getRockets()[i].decreaseLifePoints("indirect", attackConfig);
                //actual life points
                Console.WriteLine($"Life Points: {attackedPlayer.getRockets()[i].getLifePoints()}");
            }
            else
            {
                Console.WriteLine($"The enemy Rocket Launcher was not reached!");
                Console.WriteLine($"Life Points: {attackedPlayer.getRockets()[i].getLifePoints()}");
            }
        }

    }


}