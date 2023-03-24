public class Player
{
    private string _name;
    private int _points;
    private string _country;
    private List<Rocket> _rockets = new List<Rocket>();
    private int _specialAttackCounter;
    private Ground _ground;
    private bool _status;

    public Player(string name){
        _name = name;
        _points = 0;
        _specialAttackCounter = 0;
        _status = true;

    }
    public int getPoints(){
        return _points;
    }
    public void addPoints(int points){
         _points = _points + points;
    }
    public void updateStatus(bool newStatus){
        _status = newStatus;
    }
    public void setGround(Ground ground){
        _ground = ground;
    }
    public Ground getGround(){
        return _ground;
    }
    public void addRocket(Rocket rocket){
        _rockets.Add(rocket);
    }
    public void setCountry(string country){
        _country = country;
    }
    public string getCountry(){
        return _country;
    }


    
}