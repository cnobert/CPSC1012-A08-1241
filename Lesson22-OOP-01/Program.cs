 
class Program
{
    static void Main(string[] args)
    {
        
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
            _mathMark = value;
        }
    }
}

