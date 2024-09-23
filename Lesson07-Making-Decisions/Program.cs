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

bool hasMoney = false;
bool isHungry = true;

if(isHungry == true)
{
    if(hasMoney == true)
    {
        Console.WriteLine("I'm buying myself a burger!");
    }
    else// if(hasMoney == false)
    {
        Console.WriteLine("I'm hungry but I have no money.");
        Console.WriteLine("No burger for me.");
    }
}
else //isHungry == false
{
    if(hasMoney == true)
    {
        Console.WriteLine("I guess I'll save my money, no need for a burger.");
    }
    else
    {
        Console.WriteLine("No money, no big deal, since I'm not hungry.");
    }
}

#endregion
Console.WriteLine("<------------------>");