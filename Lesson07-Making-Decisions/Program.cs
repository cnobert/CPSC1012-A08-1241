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

bool hasMoney = true;
bool isHungry = false;

if(hasMoney && isHungry)
{
    Console.WriteLine("I'm buying myself a burger!");
}
else if(hasMoney && !isHungry)
{
    Console.WriteLine("I guess I'll save my money, no need for a burger.");
}
else if(!hasMoney && isHungry) //if((hasMoney == false) && isHungry)
{
    Console.WriteLine("I'm hungry but I have no money.");
    Console.WriteLine("No burger for me.");
}
else if(!hasMoney && !isHungry)
{
    Console.WriteLine("No money, no big deal, since I'm not hungry.");
}
#endregion

Console.WriteLine("<------------------>");