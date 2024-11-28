 
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
        //code goes here
    }
}
class Student 
{
    #region fields
    private string _name;
    private int _mathMark;
    private int _scienceMark;
    #endregion
    
    #region properties
    public string Name 
    {
        get
        {
            return _name;
        }
        set 
        {
            _name = value;
        }
    }

    public int MathMark 
    {
        get
        {
            return _mathMark;
        }
        set
        {
            if(value < 0 || value > 100)
            {
                throw new Exception("The mark must be between 1 and 100.");
            }
            _mathMark = value;
        }
    }
    
    public int ScienceMark
    {
        get
        {
            return _scienceMark;
        }
        set
        {
            if(value < 0 || value > 100)
            {
                throw new Exception("Science mark must be a value between 0 and 100");
            }
            _scienceMark = value;
        }
    }
    
    public double Average
    {
        //this is read-only, so there is no "set"
        get
        {
            return (MathMark + ScienceMark) / 2;
        }
    }

    #endregion

    #region methods
    public Student(string name, int mathMark, int scienceMark)
    {
        Name = name;
        MathMark = mathMark;
        ScienceMark = scienceMark;
    }

    public void Print()
    {
        Console.WriteLine($"{Name} got {MathMark} in math and {ScienceMark} in science.");
    }
    #endregion
}