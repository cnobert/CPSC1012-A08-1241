Console.WriteLine();
Console.WriteLine();

#region Exercise 1 of the Sequence Structure Programming Exercises
string name;
int age;
double annualPay;

// Console.Write("Enter your name: ");
// name = Console.ReadLine();
// Console.Write("Enter your age: ");
// age = int.Parse(Console.ReadLine());
// Console.Write("Enter your annual salary: ");
// annualPay = double.Parse(Console.ReadLine());

// //could use format string "#,##0.00", but "n" is a cool shortcut
// string output = $"My name is {name}, my age is {age} and I hope to earn {annualPay:n} per year.";
// Console.WriteLine(output);
#endregion

#region Exercise 2 of the Sequence Structure Programming Exercises

Console.WriteLine("Enter the radius and length of a cylinder:");
// could use this technique: double radius = double.Parse(Console.ReadLine()), length = double.Parse(Console.ReadLine());
double radius = double.Parse(Console.ReadLine());
double length = double.Parse(Console.ReadLine());
//double area = radius * radius * Math.PI;
double area = Math.Pow(radius, 2) * Math.PI;
double volume = area * length;
Console.WriteLine($"The area is {area:#.0000}");
Console.WriteLine($"The volume is {volume:#.0}");
#endregion

Console.WriteLine();
Console.WriteLine();