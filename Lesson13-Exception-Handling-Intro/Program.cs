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

Console.Write("Enter a number: ");
int num01 = int.Parse(Console.ReadLine());
Console.WriteLine($"You successfully entered the number {num01}.");

#endregion

#region outro text
Console.WriteLine();
Console.WriteLine();
#endregion