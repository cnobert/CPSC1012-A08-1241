﻿Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");

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
    
    //they've just entered another student, so keep track of that
    studentCounter++;
    do
    {
        Console.WriteLine("Would you like to continue? [y/n]");
        continueYN = char.ToLower(Console.ReadKey().KeyChar);
    } while(continueYN != 'n' && continueYN != 'y');
    if(continueYN == 'y')
    {
        
        if(studentCounter >= studentNames.Length)
        {
            continueYN = 'n';
            Console.WriteLine("You have entered the maximum number of students. Thank you.");
        }
    }
} while(continueYN != 'n');

Console.WriteLine();
for(int c = 0; c < studentCounter; c++)
{
    Console.WriteLine($"{c + 1}. {studentNames[c]} got {mathGrades[c]} in math.");
}
Console.WriteLine();

Console.Write($"Which student's info would you like to view?"
                + $"Enter a number between 1 and {studentNames.Length}: ");
int studentIndex = int.Parse(Console.ReadLine());
//decrement to convert from human-readable index to zero-based index
studentIndex--;
if(studentIndex >= 0 && studentIndex < studentNames.Length)
{
    Console.WriteLine($"{studentIndex + 1}. {studentNames[studentIndex]} "
                        + $"got {mathGrades[studentIndex]} in math.");
}