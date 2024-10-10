#region intro text
Console.WriteLine();
Console.WriteLine();
#endregion

#region notes from October 10, 2024
/*
•	Quiz  - on Wednesday, October 16
o	    Pre-condition loop vs post-condition loop
o	    Pre-test condition loop vs post-test condition loop
•	Relational operators and Boolean conditions
o	    <, >, <=, >=, ==, !=
o	    Boolean operators return true or false
o	    &&, ||, !
o	    Order of operations
        	Logical expressions are evaluated from left to right, unless the order of operations is modified by parentheses.
        	1. *, /, %, + -
        	2. <, >, <=, >=, ==, != Relational operators are evaluated first, then Boolean operators
        	3. “!” is first, then “&&” then “||”
o	    Examples of Boolean expressions (these would be found in parentheses in “if” statements and loops
    	10 < 10  false
    	!(10 < 10)  true
    	15 > 5 && 7 == 7  true && true  true
    	!(20 >= 20)  !(true)  false
    	12 != 12 || 9 <= 10  false || true -> true
    	25 % 5 == 0 && 30 / 6 == 5  0 == 0 && 5 == 5  true && true  true
    	!(18 == 18) && 10 < 20  !(true) && true  false && true  false
    	7 + 3 == 10 || 5 * 5 == 26  10 == 10 || 25 == 26  true || false  true
•	Exception handling
•	I will also assign a Saturday Morning Coding™ exercise

*/

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