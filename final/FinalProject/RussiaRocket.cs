public class RussiaRocket : Rocket
{
    public RussiaRocket(int lifePoints, string name, int positionX, int positionY) : base(lifePoints, name, positionX, positionY)
    {
    }

    public override void attack(int positionX, int positionY, Player attackedPlayer, int attackConfig, Player player)
    {
        //develop attack generic
        Ground attackedGround = attackedPlayer.getGround();
        //generate  other points to attack
        //Russia
        int x7 = positionX - 1;
        int y7 = positionY + 1;
        int x8 = positionX + 1;
        int y8 = positionY - 1;
        //direct attack
        for (int i = 0; i < attackedPlayer.getRocketSize(); i++)
        {
           
            if ((attackedPlayer.getRockets()[i].getPositionX() == positionX &&
            attackedPlayer.getRockets()[i].getPositionY() == positionY)){
                Console.WriteLine("Direct attack! ");
                 player.addPoints(10);
                bool statusRocket = attackedPlayer.getRockets()[i].decreaseLifePoints("direct", attackConfig);
                Console.WriteLine($"Life Points of the attacked rocket: {attackedPlayer.getRockets()[i].getLifePoints()}");
                if(statusRocket == false){
                    attackedPlayer.getRockets().RemoveAt(i);
                }

            }
            else if(
            (attackedPlayer.getRockets()[i].getPositionX() == x7 &&
            attackedPlayer.getRockets()[i].getPositionY() == y7) ||
            (attackedPlayer.getRockets()[i].getPositionX() == x8 &&
            attackedPlayer.getRockets()[i].getPositionY() == y8)
             ) {
                Console.WriteLine("Indirect attack! ");
                 player.addPoints(5);
                //decrease points of indirect attack
                attackedPlayer.getRockets()[i].decreaseLifePoints("indirect", attackConfig);
                //actual life points
                Console.WriteLine($"Life Points attacked Rocket: {attackedPlayer.getRockets()[i].getLifePoints()}");
            }
            else {
                Console.WriteLine($"The enemy Rocket Launcher was not reached!");
                Console.WriteLine($"Life Points: {attackedPlayer.getRockets()[i].getLifePoints()}");
            }
        }
    }

}