#region intro text
Console.WriteLine();
Console.WriteLine();
#endregion

#region exceptions and erros

/*
    1.  syntax error
        example: int theNum!ber = 0;
    2.  logic errors
        example: Write a program that prompts for an integer from the user, and
        prints out whether the number that they entered is between 16 and 1045
        int userNumber;
        Console.Write("Enter an integer number: ");
        userNumber = int.Parse(Console.ReadLine());
        
        logic error! should be userNumber > 16 && userNumber < 1045
        if(userNumber < 16 && userNumber > 1045)
        {
            //tell them it's between the two
        }
    3.  runtime error
        -happen at runtime
        -ArrayIndexOutOfBounds Exception
        --example string name = "abc"; Console.Write(name[16]);
*/
//when there is a dangerous piece of code (one that may throw an exception), we will put that 
//code into a try/catch block
// try
// {
//     Console.Write("Enter a number: ");
//     int num01 = int.Parse(Console.ReadLine());
//     Console.WriteLine($"You successfully entered the number {num01}.");
// }
// catch(Exception theException)
// {
//     Console.WriteLine("There was an exception, here is the message:");
//     Console.WriteLine(theException.Message);
// }

int userAge = 0;
bool validInput = false;

do
{
    Console.Write("How old are you? Please enter a whole number: ");
    try
    {
        userAge = int.Parse(Console.ReadLine());
        validInput = true; //this line of code is never reached if an exception was thrown the line before
    }
    catch(Exception e)
    {
        Console.WriteLine(e.Message);
        Console.WriteLine("Please try again.");
    }
} while(validInput == false); //while (!validInput)


#endregion

#region outro text
Console.WriteLine();
Console.WriteLine();
#endregion