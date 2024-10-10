#region intro text
Console.WriteLine();
Console.WriteLine();
#endregion

#region review
// int count = 0;
// while(count < 10)
// {
//     Console.Write($"{count++} ");
// }
Console.WriteLine();
char answerYN = 'n';
string city;
do
{
    Console.Write("What city do you live in? ");
    city = Console.ReadLine();
    //this could be a calculation or more questions for the user
    if(city == "Edmonton" || city.Equals("Winnipeg"))
    {
        Console.WriteLine("Enjoy the winter!");
    }
    else
    {
        Console.WriteLine("Sounds warm.");
    }
    Console.Write("Would you like to continue? ");
    answerYN = char.ToLower(Console.ReadKey().KeyChar);
    Console.WriteLine();
}while(answerYN != 'n');

#endregion

#region for loops
//everything you can do with a "for" loop, you can with a "while" loop
for(int c = 0; c < 10; c++)
{
    Console.WriteLine(c);
}
//exercise: write a "for" loop that outputs the numbers
//from 103 down to 4
for(int c = 103; c >= 4; c--)
{
    Console.WriteLine(c);
}
#endregion

#region Exercise: Display the characters
Console.Write("Enter a string: ");
string theString = Console.ReadLine();

for(int arrayIndex = 0; arrayIndex < theString.Length; arrayIndex++)
{
    Console.WriteLine(theString[arrayIndex]);
}

#endregion
#region outro text
Console.WriteLine();
Console.WriteLine();
#endregion