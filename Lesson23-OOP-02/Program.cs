
using System.Diagnostics.Contracts;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");

        Student s01 = new Student("Jimmy McNulty", 82, 67);
        Student s02 = new Student("Stringer Bell", 99, 98);

        //exercise: fix the "Print" method so that it includes the science mark
        //"Print" is an instance method - it is called on individual instances
        //(objects) of a class
        s01.Print();
        s02.Print();
        //"PrintDescription" is a class method - no instance is needed for it to 
        //be called
        Student.PrintDescription();
    }
}
class Student 
{
    //"private" means that nothing outside of the class
    //can access these data members directly.
    private string _name;
    private int _mathMark;
    private int _scienceMark;

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
    
    
    //a constructor is a method that has the same name as the class
    //a "greedy" constructor is a constructor that has a parameter 
    //for each and every property/field in the class/object.
    //"field" is a synonym for "data member"
    public Student(string name, int mathMark, int scienceMark)
    {
        Name = name;
        MathMark = mathMark;
        ScienceMark = scienceMark;
    }

    //instance method (don't need the "static" keyword, a different method is called
    //for each instance of the class)
    public void Print()
    {
        Console.WriteLine($"{Name} got {MathMark} in math and {ScienceMark} in science.");
    }
    //a class method (static) belongs to the class and not a specific instance
    public static void PrintDescription()
    {
        Console.WriteLine("The student class stores data about NAIT students.");
    }
}

