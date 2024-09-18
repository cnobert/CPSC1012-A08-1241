using System.Runtime.CompilerServices;

Console.WriteLine();
Console.WriteLine();

#region Loose Ends (toUpper, toLower, +=, -=)
// string number01 = "100";
// Console.WriteLine(number01 + 100);
// Console.WriteLine(100 + (100 + ""));
// Console.WriteLine(100 + 100);

// Console.Write("What's the name of city you were born in? ");
// string cityName = Console.ReadLine();

// Console.WriteLine("The city, in all capitals, is: " + cityName.ToUpper());
// Console.WriteLine(cityName + ", in all lower case lettters, is " + cityName.ToLower());

// int age = 10;
// age = age + 5;
// age += 5;
// age = age - 5;
// age -= 5;
// age++;
// age++;
// age--;
// age *= age;
// age /= age;
// age = age - age;
// Console.WriteLine("Current age: " + age);

#endregion

#region Escape Characters
//to insert certain characters into our strings, we use the escape character, "\"
//Console.WriteLine("He yelled out loud: \"yahoo!\".");

//common escape characters include:
//backslash \\
//double quote \"
//newline \n
//tab \t
// Console.WriteLine("They yelled...\n\n\n\n\"boo!\"");
// Console.Write("\n");
#endregion

#region String interpolation
//read https://lms.nait.ca/d2l/le/content/25529/viewContent/1173912/View
int firstNum = 150;
double secondNum = 1234.56789;
Console.WriteLine("firstNum: " + firstNum + "\nsecondNum: " + secondNum);

//string interpolation
Console.WriteLine($"firstNum: {firstNum}\nsecondNum: {secondNum}");
Console.WriteLine($"firstNum: {firstNum:0000}\nsecondNum: {secondNum:0.00}");
Console.WriteLine($"firstNum: ${firstNum:#,##0.00} secondNum: ${secondNum:#,##0.00}");
//The # means show a number in this place if it exists and the 0 means show a digit in this place
//no matter what
#endregion

Console.WriteLine();
Console.WriteLine();