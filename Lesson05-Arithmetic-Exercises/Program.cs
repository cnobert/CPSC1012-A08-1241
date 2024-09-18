using System.Runtime.CompilerServices;

Console.WriteLine();
Console.WriteLine();

#region Loose Ends (toUpper, toLower, +=, -=)
string number01 = "100";
Console.WriteLine(number01 + 100);
Console.WriteLine(100 + (100 + ""));
Console.WriteLine(100 + 100);

Console.Write("What's the name of city you were born in? ");
string cityName = Console.ReadLine();

Console.WriteLine("The city, in all capitals, is: " + cityName.ToUpper());
Console.WriteLine(cityName + ", in all lower case lettters, is " + cityName.ToLower());

int age = 10;
age = age + 5;
age += 5;
age = age - 5;
age -= 5;
age++;
age++;
age--;
age *= age;
age /= age;
age = age - age;
Console.WriteLine("Current age: " + age);

#endregion

#region Escape Characters
//to insert certain characters into our strings, we use the escape character, "\"
Console.WriteLine("He yelled out loud: \"yahoo!\".");

//common escape characters include:
//backslash \\
//double quote \"
//newline \n
//tab \t
Console.WriteLine("They yelled...\n\n\n\n\"boo!\"");
Console.Write("\n");
#endregion



Console.WriteLine();
Console.WriteLine();