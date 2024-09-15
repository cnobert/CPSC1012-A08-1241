Console.WriteLine();
Console.WriteLine();


Console.Write("Hi. Please enter your first name:");
string firstName = Console.ReadLine();
Console.WriteLine("Pleased to make your acquaintance, " + firstName);

Console.Write("How old are you, " + firstName + "?");

// int age = Convert.ToInt32(Console.ReadLine());
int age = int.Parse(Console.ReadLine());

Console.WriteLine("You are " + age + " years old.");

Console.Write("What is your gradepoint average? ");
float average = float.Parse(Console.ReadLine());
Console.WriteLine("You average is: " + average);

Console.WriteLine();
Console.WriteLine();