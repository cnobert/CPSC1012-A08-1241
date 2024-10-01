#region intro text
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("<---------------------->");
Console.WriteLine("<---------------------->");
Console.WriteLine();
Console.WriteLine();
#endregion

#region notes on boolean operators
/*
    == equality operator (if both sides equal, returns true)
    != not equal operator (if both sides are not equal, returns true)
    && "and" operator (if both sides true, returns true)
    || "or" operator (if one side true, returns true))
    ! "not" operator (returns the opposite of the value it operates on)
    < "strictly less than" (if left side strictly less, returns true))
    > "strictly greater than" (if left side stricty great than, returns true))
    <= "less than or equal to" (if left side less than or equal to, returns true)
    >= "great than or equal to" (if left side greater than or equal to, returns true))
*/
#endregion

#region "!" operator and "!=" operator

// Console.Write("Enter a number: ");
// int theNumber = int.Parse(Console.ReadLine());

// if(theNumber != 100)
// {
//     Console.WriteLine("The number is not 100.");
// }
// else
// {
//     Console.WriteLine("The number IS 100!!!!!!");
// }

// bool isBig = true;

// if(!isBig)
// {
//     Console.WriteLine("NOT BIG");
// }
// else
// {
//     Console.WriteLine("BIG");
// }

#endregion

#region Question 02, Decision Making Exercises 02 doc
/*
Write a program that will determine the cost of admission for a theatre. The price of admission
is based on the age of the customer. Your program should prompt the user for their age and
then display the correct admission amount.
• Children 6 and under = FREE ($0.00)
• Students 7 to 17 = $9.80
• Adults 18 to 54 = $11.35
• Seniors 55+ = $10.00
*/

Console.Write("What is your age? ");
int age = int.Parse(Console.ReadLine());

string admissionMessage = "";
if(age <= 6) // age < 7
{
    admissionMessage = "You get in for free!";
}
else if (age < 18) //between 7 and 17
{
    admissionMessage = "$9.80 please!";
}
else if(age < 55) //between 18 and 54
{
    admissionMessage = "$11.35 please!";
}
else //55+
{
    admissionMessage = "$10.00 please!";
}

//here's another version that is less efficient but will still get the same answer
admissionMessage = "You get in for ";
if(age > 0 && age <= 6)
{
    admissionMessage += "free.";
}
else if (age > 6 && age < 18)
{
    admissionMessage += "$9.80.";
}
else if (age >= 18 && age < 55)
{
    admissionMessage += "$11.35.";
}
else if (age >= 55)
{
    admissionMessage += "$10.00.";
}
Console.WriteLine(admissionMessage);

#endregion

#region outro text
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("<---------------------->");
Console.WriteLine("<---------------------->");
Console.WriteLine();
Console.WriteLine();
#endregion