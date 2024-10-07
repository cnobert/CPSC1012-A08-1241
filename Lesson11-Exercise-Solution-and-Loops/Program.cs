#region intro text
Console.WriteLine("<---------------------->");
Console.WriteLine("<---------------------->");
Console.WriteLine();
#endregion

#region Question 2, Decision Making Exercises 3

// const double PoundsInAKilo = 2.2046;
// const double OuncesInALitre = 33.8140226;
// const double CentimetresInAnInch = 0.39370;
// const double FahrenheitConverter01 = 32;
// const double FahrenheitConverter02 = 1.8;

// string menuString = "Choose one of the following conversions:\n" +
//                     "[a] POUNDS TO KILOGRAMS\n" +
//                     "[b] FLUID OUNCES (U.S.) TO LITRES\n" +
//                     "[c] INCHES TO CENTIMETERS\n" + 
//                     "[d] FAHRENHEIT TO CELSIUS\n" +
//                     "Type your selection here ---> ";
// Console.Write(menuString);
// char selection = char.ToLower(Console.ReadKey().KeyChar);
// Console.WriteLine();
// double valueToBeConverted;
// double convertedValue;
// switch(selection)
// {
//     case 'a': //pounds to kilos
//         Console.Write("How many pounds would like to convert? ");
//         valueToBeConverted = double.Parse(Console.ReadLine());
//         convertedValue = valueToBeConverted / PoundsInAKilo;
//         Console.WriteLine($"{valueToBeConverted} pounds, in kilos, is {convertedValue:n2}");
//         break;
//     case 'b': //ounces to litres
//         Console.Write("How many ounces would you like to convert? ");
//         valueToBeConverted = double.Parse(Console.ReadLine());
//         convertedValue = valueToBeConverted / OuncesInALitre;
//         Console.WriteLine($"{valueToBeConverted} ounces, in litres, is {convertedValue:n}");
//         break;
//     case 'c': //inches to centimetres
//         Console.Write("How many inches would you like to convert? ");
//         valueToBeConverted = double.Parse(Console.ReadLine());
//         convertedValue = valueToBeConverted / CentimetresInAnInch;
//         Console.WriteLine($"{valueToBeConverted} inches, in centimetres, is {convertedValue:n}");
//         break;
//     case 'd': //fahrenheit to celcius
//         Console.Write("What Fahrenheit temperature would you like converted? ");
//         valueToBeConverted = double.Parse(Console.ReadLine());
//         convertedValue = (valueToBeConverted - FahrenheitConverter01) / FahrenheitConverter02;
//         Console.WriteLine($"{valueToBeConverted} degrees Fahrenheit, in Celcius, is {convertedValue:n}");
//         break;
// }

#endregion

#region pre-condition loop
//first we check a boolean condition, then if true we loop until it isn't

int loopCounter = 0;
while(loopCounter < 3)
{
    Console.WriteLine(loopCounter);
    loopCounter++;  //same as loopCounter += 1 
                    //which is same as loopCounter = loopCounter + 1
}
//infinite loop
//while(true)
//{
// Console.Writeline("help I'm stuck in infinity");
//}

//with a while loop, print out 1, 2, 3
loopCounter = 1;
while(loopCounter <= 3)
{
    Console.WriteLine(loopCounter);
    loopCounter++;  //same as loopCounter += 1 
                    //which is same as loopCounter = loopCounter + 1
}

//print out the numbers from 10 to 1, in descending order
loopCounter = 10;
while(loopCounter >= 1)
{
    Console.WriteLine(loopCounter);
    loopCounter--; //loopCounter -= 1 or loopCounter = loopCounter - 1;
}

//exercise: write a loop that outputs the multiples of 5 from 5 to 100
loopCounter = 5;
while(loopCounter <= 100)
{
    Console.WriteLine(loopCounter);
    loopCounter += 5;
}
#endregion

#region post-condition loop

//do
//{
//}
//while(condition)
char menuSelection = 'q';
do
{
    Console.WriteLine("Choose a menu item:");
    Console.WriteLine("\t'j' to hear a joke");
    Console.WriteLine("\t'a' to find out how old I am");
    Console.WriteLine("\t'q' to quit");
    menuSelection = Console.ReadLine()[0];
    switch(menuSelection)
    {
        case 'j':
            Console.Write("What do you call a pony with a cough?\n");
            Console.WriteLine("A little horse.");
            break;
        case 'a':
            Console.WriteLine("I am 49 years old.");
            break;
        case 'q':
            Console.WriteLine("Buh Bye");
            break;
        default:
            Console.WriteLine("Not a valid option, try again.");
            break;
    }
} while (menuSelection != 'q');
#endregion

#region outro text
Console.WriteLine();
Console.WriteLine("<---------------------->");
Console.WriteLine("<---------------------->");
#endregion