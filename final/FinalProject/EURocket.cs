public class EURocket : Rocket
{
    public EURocket(int lifePoints, string name, int positionX, int positionY) : base(lifePoints, name, positionX, positionY)
    {
    }

    public override void attack(int positionX, int positionY, Player attackedPlayer, int attackConfig, Player player)
    {
        //develop attack generic
        Ground attackedGround = attackedPlayer.getGround();
        //generate  other points to attack
        //UE
        int x5 = positionX + 1;
        int y5 = positionY + 1;
        int x6 = positionX - 1;
        int y6 = positionY - 1;
        //direct attack
        for (int i = 0; i < attackedPlayer.getRocketSize(); i++)
        {

            if ((attackedPlayer.getRockets()[i].getPositionX() == positionX &&
            attackedPlayer.getRockets()[i].getPositionY() == positionY))
            {
                attackedPlayer.getRockets()[i].attackAnimation();
                attackedPlayer.getRockets()[i].exploitAnimation(); 
                Console.WriteLine();
                Console.WriteLine("********************");
                Console.WriteLine("Direct attack! ");
                Console.WriteLine("********************");
                Console.WriteLine();
                player.addPoints(10);

                bool statusRocket = attackedPlayer.getRockets()[i].decreaseLifePoints("direct", attackConfig);
                Console.WriteLine();
                Console.WriteLine($"Life Points attacked rocket: {attackedPlayer.getRockets()[i].getLifePoints()}");
                Console.WriteLine();
                if (statusRocket == false)
                {
                    attackedPlayer.getRockets().RemoveAt(i);
                }

            }
            else if ((
            (attackedPlayer.getRockets()[i].getPositionX() == x5 &&
            attackedPlayer.getRockets()[i].getPositionY() == y5) ||
            (attackedPlayer.getRockets()[i].getPositionX() == x6 &&
            attackedPlayer.getRockets()[i].getPositionY() == y6)
             ))
            {
                 attackedPlayer.getRockets()[i].attackAnimation();
                attackedPlayer.getRockets()[i].exploitAnimation(); 
                Console.WriteLine();
                Console.WriteLine("********************");
                Console.WriteLine("Indirect attack! ");
                Console.WriteLine("********************");

                 Console.WriteLine();
                player.addPoints(5);
                //decrease points of indirect attack
                attackedPlayer.getRockets()[i].decreaseLifePoints("indirect", attackConfig);
                //actual life points
                Console.WriteLine();
                Console.WriteLine($"Life Points attacked Rocket: {attackedPlayer.getRockets()[i].getLifePoints()}");
                Console.WriteLine();
            }
            else
            {
                attackedPlayer.getRockets()[i].attackAnimation();
                Console.WriteLine();
                Console.WriteLine($"The enemy Rocket Launcher was not reached!");
                Console.WriteLine($"Life Points: {attackedPlayer.getRockets()[i].getLifePoints()}");
                 Console.WriteLine();
            }
        }
    }


}