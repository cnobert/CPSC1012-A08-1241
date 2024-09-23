Console.WriteLine("<------------------>");

#region first "if" statement

// bool isBig = false;

// if(isBig == true)
// {
//     Console.WriteLine("It's BIG!");
// }
// else
// {
//     Console.WriteLine("It's NOT BIG.");
// }

#endregion

#region nested "if" statement

// bool hasMoney = false;
// bool isHungry = false;

// if(isHungry == true)
// {
//     if(hasMoney == true)
//     {
//         Console.WriteLine("I'm buying myself a burger!");
//     }
//     else// if(hasMoney == false)
//     {
//         Console.WriteLine("I'm hungry but I have no money.");
//         Console.WriteLine("No burger for me.");
//     }
// }
// else //isHungry == false
// {
//     if(hasMoney == true)
//     {
//         Console.WriteLine("I guess I'll save my money, no need for a burger.");
//     }
//     else
//     {
//         Console.WriteLine("No money, no big deal, since I'm not hungry.");
//     }
// }

#endregion

#region "if" statement with compound Boolean expressions

// bool hasMoney = true;
// bool isHungry = false;

// if(hasMoney && isHungry)
// {
//     Console.WriteLine("I'm buying myself a burger!");
// }
// else if(hasMoney && !isHungry)
// {
//     Console.WriteLine("I guess I'll save my money, no need for a burger.");
// }
// else if(!hasMoney && isHungry) //if((hasMoney == false) && isHungry)
// {
//     Console.WriteLine("I'm hungry but I have no money.");
//     Console.WriteLine("No burger for me.");
// }
// else if(!hasMoney && !isHungry)
// {
//     Console.WriteLine("No money, no big deal, since I'm not hungry.");
// }
#endregion

#region Question 1 from  Decision Making Exercises 2 (https://lms.nait.ca/d2l/le/content/25527/viewContent/1173615/View)
/*
Write a program that will prompt for a number and display “positive” if it is greater than zero,
“negative” if it is less than zero, and “zero” if it is equal to zero
*/
Console.Write("Enter a number:");
int theNumber = int.Parse(Console.ReadLine());
if(theNumber < 0)
{
    Console.WriteLine("negative");
}
else if(theNumber > 0)
{
    Console.WriteLine("positive");
}
else// if (theNumber == 0)
{
    Console.WriteLine("zero");
}

#endregion

Console.WriteLine("<------------------>");