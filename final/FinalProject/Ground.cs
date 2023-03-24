public class Ground 
{
    private List<int> pointsX = new List<int>();
    private List<int> pointsY = new List<int>();
    private int _numberOfRockets;
    private int _xSize;
    private int _ySize;
    public Ground (int xSize, int ySize, int numberOfRockets){
        _xSize = xSize;
        _ySize = ySize;
        _numberOfRockets = numberOfRockets;
    }
    public int getNumberOfRockets(){
        return _numberOfRockets;
    }
    public void setRocketPostion(int x, int y){
        //update the positions x and y in the ground with a 1
    }
    public void fillGround(int size){
        //fill the ground with O in X and Y axis
        
    }
    



    
}