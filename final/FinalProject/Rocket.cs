public class Rocket
{
    private string _name;
    private int _lifePoints;
    private bool _state;
    private int _positionX;
    private int _positionY;

    public Rocket(int lifePoints, string name, int positionX, int positionY)
    {
        _name = name;
        _lifePoints = lifePoints;
        _positionX = positionX;
        _positionY = positionY;
    }
    public void destroy()
    {
        _state = false;
    }
    public virtual void attack(int positionX, int positionY, Player attackedPlayer, int attackConfig, Player player)
    {
        //develop attack generic
        Ground attackedGround = attackedPlayer.getGround();
        //generate  other points to attack
        //USA
        int x1 = positionX + 1;
        int y1 = positionY;
        int x2 = positionX - 1;
        int y2 = positionY;
        //China
        int x3 = positionX;
        int y3 = positionY + 1;
        int x4 = positionX;
        int y4 = positionY - 1;
        //UE
        int x5 = positionX + 1;
        int y5 = positionY + 1;
        int x6 = positionX - 1;
        int y6 = positionY - 1;
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
                Console.WriteLine("Direct special attack! ");
                player.addPoints(10);
                
                bool statusRocket = attackedPlayer.getRockets()[i].decreaseLifePoints("direct", attackConfig);
                Console.WriteLine($"Life Points of the attacked rocket: {attackedPlayer.getRockets()[i].getLifePoints()}");
                if(statusRocket == false){
                    attackedPlayer.getRockets().RemoveAt(i);
                }

            }
            else if((attackedPlayer.getRockets()[i].getPositionX() == x1 &&
            attackedPlayer.getRockets()[i].getPositionY() == y1) ||
            (attackedPlayer.getRockets()[i].getPositionX() == x2 &&
            attackedPlayer.getRockets()[i].getPositionY() == y2) ||
            (attackedPlayer.getRockets()[i].getPositionX() == x3 &&
            attackedPlayer.getRockets()[i].getPositionY() == y3) ||
            (attackedPlayer.getRockets()[i].getPositionX() == x4 &&
            attackedPlayer.getRockets()[i].getPositionY() == y4) ||
            (attackedPlayer.getRockets()[i].getPositionX() == x5 &&
            attackedPlayer.getRockets()[i].getPositionY() == y5) ||
            (attackedPlayer.getRockets()[i].getPositionX() == x6 &&
            attackedPlayer.getRockets()[i].getPositionY() == y6) ||
            (attackedPlayer.getRockets()[i].getPositionX() == x7 &&
            attackedPlayer.getRockets()[i].getPositionY() == y7) ||
            (attackedPlayer.getRockets()[i].getPositionX() == x8 &&
            attackedPlayer.getRockets()[i].getPositionY() == y8)
             ) {
                Console.WriteLine("Indirect special attack! ");
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
    public int getPositionX()
    {
        return _positionX;
    }
    public int getPositionY()
    {
        return _positionY;
    }
    public bool decreaseLifePoints(string typeOfAttack, int attackConfig){
        if(typeOfAttack == "direct"){
            _lifePoints = _lifePoints - attackConfig;
            if(_lifePoints <= 0){
                //change the state of the rocket to destroy it
                _state = false;
                Console.WriteLine("The Rocket was destroyed!");
                return false;
            }
            return true;

        }
        else {
            _lifePoints = _lifePoints - attackConfig/2;
            if(_lifePoints <= 0){
                //change the state of the rocket to destroy it
                _state = false;
                Console.WriteLine("The Rocket was destroyed!");
                return false;
            }
            return true;
        }
    }
    public int getLifePoints(){
        return _lifePoints;
    }
    public void attackAnimation(){
        int fromNumber = 5;
        Console.WriteLine();
        for (int i = 0; fromNumber > i; i++){
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("->");
        }
        Console.WriteLine();
    }
    public virtual void exploitAnimation(){
        int fromNumber = 5;
        Console.WriteLine();
        for (int i = 0; fromNumber > i; i++){
            Console.Write(".");
            Thread.Sleep(500);
            
        }
        Console.WriteLine("<--- BOOM!!! --->");
        Thread.Sleep(1000);
        Console.WriteLine();
    }
}