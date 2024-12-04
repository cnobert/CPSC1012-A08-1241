 
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
        List<Student> students;
        students = new List<Student>();
        Student s01 = new Student("Ayla Smith", 81, 61);
        students.Add(s01);
        students[0].Print();
        s01.MathMark = 0;
        students[0].Print();
        students.Add(new Student("Bill Bob", 99, 70));
        students.Add(new Student("Brinda Kaur", 67, 77));
        Console.WriteLine("---------");
        foreach(Student s in students)
        {
            s.Print();
        }
        students.Remove(s01);
        Console.WriteLine("-----");
        foreach(Student s in students)
        {
            s.Print();
        }
        students.Remove(students[0]);
        Console.WriteLine("-----");
        foreach(Student s in students)
        {
            s.Print();
        }
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

    //this read-only property will return the "rank" of the student
    public string StudentRanking
    {
        get
        {
            string ranking = "Failing";
            if(Average >= 90)
            {
                ranking = "Honours with distinction";
            }
            else if (Average >= 80)
            {
                ranking = "Honours";
            }
            else if(Average >= 50)
            {
                ranking = "Passing";
            }
            return ranking;
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