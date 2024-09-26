Console.WriteLine();
Console.WriteLine();

#region Exercise 1 of the Sequence Structure Programming Exercises
string name;
int age;
double annualPay;

Console.Write("Enter your name: ");
name = Console.ReadLine();
Console.Write("Enter your age: ");
age = int.Parse(Console.ReadLine());
Console.Write("Enter your annual salary: ");
annualPay = double.Parse(Console.ReadLine());

string output = $"My name is {name}, my age is {age} and I hope to earn {annualPay} per year.";
Console.WriteLine(output);
#endregion



Console.WriteLine();
Console.WriteLine();