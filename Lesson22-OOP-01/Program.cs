 
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
        Student s01 = new Student();
        s01.Name = "Jimmy McNulty";
        s01.MathMark = -82;
        Console.WriteLine($"{s01.Name} got {s01.MathMark} in math.");
    }
}
class Student 
{
    //"private" means that nothing outside of the class
    //can access these data members directly.
    private string _name;
    private int _mathMark;

    //the "setters" and "getters" are accessed via properties
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
}

