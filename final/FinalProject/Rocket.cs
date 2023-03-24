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
    public virtual void attack(int positionX, int positionY, Player attackedPlayer, int attackConfig)
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
            if((attackedPlayer.getRockets()[i].getPositionX() == x1 &&
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
                Console.WriteLine("Indirect attack! ");
                //decrease points of indirect attack
                attackedPlayer.getRockets()[i].decreaseLifePoints("direct", attackConfig);
            }
            else if ((attackedPlayer.getRockets()[i].getPositionX() == positionX &&
            attackedPlayer.getRockets()[i].getPositionY() == positionY)){
                Console.WriteLine("Direct attack! ");
                bool statusRocket = attackedPlayer.getRockets()[i].decreaseLifePoints("indirect", attackConfig);
                if(statusRocket == false){
                    attackedPlayer.getRockets().RemoveAt(i);
                }

            }
            else {
                Console.WriteLine($"The enemy Rocket Launcher was not reached!");
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
                //desactivar Rocket porque fue destruido
                _state = false;
                Console.WriteLine("They Rocket was destroyed!");
                return false;
            }
            return true;

        }
        else {
            _lifePoints = _lifePoints - attackConfig/2;
            if(_lifePoints <= 0){
                //desactivar Rocket porque fue destruido
                _state = false;
                Console.WriteLine("They Rocket was destroyed!");
                return false;
            }
            return true;
        }
    }
}