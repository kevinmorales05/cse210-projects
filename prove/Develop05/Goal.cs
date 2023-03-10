public abstract class  Goal {
    private bool _status;
    private string _goalDescription;
    private int _pointsToWin;




    public Goal(string goalDescription, int points){
        _status = true;
        _goalDescription = goalDescription;
        _pointsToWin = points;
    }
//change status
    public abstract void updateStatus();
//print the goal
    public string getGoalDescription(){
        return _goalDescription;
    }
    public int getPointsToWin(){
        return _pointsToWin;
    }
    public void setStatus(){
        _status = false;
    }



}