public class Rocket {
    private string _name;
    private int _lifePoints;
    private bool _state;
    private int _positionX;
    private int _positionY;

    public Rocket(int lifePoints, string name, int positionX, int positionY  ){
        _name = name;
        _lifePoints = lifePoints;
        _positionX = positionX;
        _positionY = positionY;
    }
    public void destroy(){
        _state = false;
    }
    public void specialAttack(){
        //develop special attack
    }
    public virtual void attack(){
        //develop attack generic
    }


}