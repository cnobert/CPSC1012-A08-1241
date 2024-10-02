#region intro text
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("<---------------------->");
Console.WriteLine("<---------------------->");
Console.WriteLine();
Console.WriteLine();
#endregion
#region escape characters

/*
    escape characters are a way to insert special characters into strings
    they include
    ", ' , \, newline, tab
*/
// string sentence01 = "I heard my brother say \"hi\".";
// Console.WriteLine(sentence01);
// Console.WriteLine("This is a backslash character: \\");
// Console.Write("Instead of using Console.WriteLine, we could just put the newline char at the end of our strings. \n");
// Console.WriteLine("If we wanted to tab things out, we would insert these \t\t characters.");

// char aCharacter = '\'';

#endregion

#region strings

string name = "Conrad";
Console.Write("" + name[5] + name[4] + name[3] + 
                    name[2] + name[1] + name[0] + "\n\n");
string fullName = "Taylor Swift";
Console.WriteLine($"The number of chars in {fullName} is {fullName.Length}");
Console.WriteLine($"\"Star Wars\" has {"Star Wars".Length} characters.");

string city = "Edmonton";
Console.WriteLine($"The word \"Edmonton\", in all caps, is {"Edmonton".ToUpper()}");
Console.WriteLine($"The word \"Edmonton\", in all caps, is {city.ToUpper()}");
//don't forget the .ToLower() method

string upperFullName = fullName.ToUpper();
//upperFullName now equals "TAYLOR SWIFT"
int index = upperFullName.IndexOf('F');
Console.WriteLine("The index is " + index);

string whatWeAreLookingFor = "wiF";
Console.Write($"{fullName} contains \"{whatWeAreLookingFor}\"? ");
Console.WriteLine($"{fullName.Contains(whatWeAreLookingFor)}" );

Console.Write($"{fullName} contains \"{whatWeAreLookingFor}\"?(case insensitive) ");
Console.WriteLine($"{fullName.ToUpper().Contains(whatWeAreLookingFor.ToUpper())}" );

Console.Write($"\n\n\n{fullName.Substring(8)}");

string hockeyName = "Connor McDavid";
string firstName = hockeyName.Substring(0, hockeyName.IndexOf(' '));
string lastName = hockeyName.Substring(hockeyName.IndexOf(" ") + 1);
Console.WriteLine($"First Name: {firstName}\nLast Name: {lastName}");



#endregion

#region outro text
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("<---------------------->");
Console.WriteLine("<---------------------->");
Console.WriteLine();
Console.WriteLine();
#endregion