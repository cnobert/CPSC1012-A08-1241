#region intro text
Console.WriteLine("<---------------------->");
Console.WriteLine("<---------------------->");
Console.WriteLine();
#endregion

#region switch statements
//logically the same as a simple, stacked, if/else statement

//let's get 1-character long input from the user
//more info on that here https://www.geeksforgeeks.org/different-methods-to-read-a-character-in-c-sharp/

Console.Write("What grade did you earn? ");
//string grade = Console.ReadLine()[0] + "";

//another way to convert to a string with the ToString() method
//string grade = Console.ReadLine()[0].ToString();
//a third way to convert to a string is to "cast" the character to a string
//string grade = (string) Console.ReadLine();

string grade = Console.ReadKey().KeyChar.ToString();
Console.WriteLine();
string output = "";
switch(grade.ToUpper())
{
    case "A":
        output = "Congratulations!";
        break;
    case "B":
        output = "Very good!";
        break;
    case "C":
        output = "So so!";
        break;
    case "D":
        output = "At least you passed.";
        break;
    case "F":
        output = "Sorry, you fail.";
        break;
    default:
        output = "Invalid grade. Try again.";
        break;
}
Console.WriteLine(output);
#endregion


#region outro text
Console.WriteLine();
Console.WriteLine("<---------------------->");
Console.WriteLine("<---------------------->");
#endregion