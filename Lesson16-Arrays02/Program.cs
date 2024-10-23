Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");

//parallel arrays
const int NumStudents = 5;

string[] studentNames = new string[NumStudents];
int[] mathGrades = new int[NumStudents];
//int [] chemGrades = new int[NumStudents];

char continueYN = 'n';
int studentCounter = 0;
do
{
    Console.Write($"Enter the student name for student {studentCounter + 1} ");
    studentNames[studentCounter] = Console.ReadLine();
    
    bool inputIsValid = false;
    do
    {
        Console.Write($"Enter the math grade for {studentNames[studentCounter]}: ");
        try
        {
            mathGrades[studentCounter] = int.Parse(Console.ReadLine());
            if(mathGrades[studentCounter] >= 0 && mathGrades[studentCounter] <= 100)
            {
                inputIsValid = true;
            }
            else
            {
                Console.WriteLine("The grade you entered is not between 0 and 100. Try again.");
            }
        }
        catch(Exception e)
        {
            Console.WriteLine("The grade you entered is not a number. Try again.");
        }
    }
    while(!inputIsValid);

    do
    {
        Console.WriteLine("Would you like to continue? [y/n]");
        continueYN = char.ToLower(Console.ReadKey().KeyChar);
    } while(continueYN != 'n' && continueYN != 'y');
    if(continueYN == 'y')
    {
        studentCounter++;
        if(studentCounter >= studentNames.Length)
        {
            continueYN = 'n';
            Console.WriteLine("You have entered the maximum number of students. Thank you.");
        }
    }
} while(continueYN != 'n');

for(int c = 0; c < studentNames.Length; c++)
{
    Console.WriteLine($"{c + 1}. {studentNames[c]} got {mathGrades[c]} in math.");
}