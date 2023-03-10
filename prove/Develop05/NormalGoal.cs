public class NormalGoal : Goal
{
    private string _lifeArea; //job, family, health, 
    public NormalGoal(string goalDescription, int points, string lifeArea) : base(goalDescription, points)
    {
        _lifeArea = lifeArea;
    }

    public override void updateStatus()
    {
        base.setStatus();
    }
    public string getLifeArea(){
        return _lifeArea;
    }
}