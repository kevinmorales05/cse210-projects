public class User{
    private string _name; //user name
    private int _score; //actual score
    private List<NormalGoal> _mortalGoals = new List<NormalGoal>();
    private List<EternalGoal> _eternalGoals =  new List<EternalGoal>();

    private List<EventRegistry> _events = new List<EventRegistry>();

    public User(string name){
        _name = name;
        _score = 0;

    }
    public void addEternalGoal(EternalGoal goal){
        _eternalGoals.Add(goal);
    }
    public void addMortalGoal(NormalGoal goal){
        _mortalGoals.Add(goal);
    }
   public void addEvent(EventRegistry eventToAdd){
        _events.Add(eventToAdd);
   }
    public string getName(){
        return _name;
    }
    public List<NormalGoal> getMortalGoals(){
        return _mortalGoals ;
    }
    public List<EternalGoal> GetEternalGoals(){
        return _eternalGoals;
    }
    public List<EventRegistry> GetEvents(){
        return _events;
    }


}