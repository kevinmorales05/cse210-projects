public class Ground
{
    private List<int> _pointsX = new List<int>();
    private List<int> _pointsY = new List<int>();
    private int _numberOfRockets;
    private int _xSize;
    private int _ySize;
    public Ground(int xSize, int ySize, int numberOfRockets)
    {
        _xSize = xSize;
        _ySize = ySize;
        _numberOfRockets = numberOfRockets;
        //Fill the ground with 0
        fillGround(xSize);
    }
    public int getNumberOfRockets()
    {
        return _numberOfRockets;
    }
    public void setRocketPostion(int x, int y)
    {
        //update the positions x and y in the ground with a 1
        _pointsX[x] = 1;
        _pointsY[y] = 1;
    }
    public void fillGround(int size)
    {
        for (int i = 0; i < _xSize; i++)
        {
            _pointsX.Add(0);
            _pointsY.Add(0);
        }

    }
    public void printGround()
    {
        Console.WriteLine();
        Console.WriteLine("This is the ground");
        Console.WriteLine($"You have {_numberOfRockets} Rockets.");
        Console.WriteLine();
        Console.WriteLine("***************************");
        Console.WriteLine("X axis");
        for (int i = 0; i < _xSize; i++)
        {
            Console.Write(_pointsX[i]+" ");
        }
        Console.WriteLine();
        Console.WriteLine("Y axis");
        for (int i = 0; i < _ySize; i++)
        {
            Console.Write(_pointsY[i]+" ");
        }
        Console.WriteLine();
        Console.WriteLine("***************************");
        Console.WriteLine();
    }





}