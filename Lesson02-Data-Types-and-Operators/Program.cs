Console.WriteLine();
Console.WriteLine();

// int age01 = 13;
// int age02 = 45;
// int age03 = 90;

int age01 = 13, age02 = 45, age03 = 90;

age01 = age01 + 1;
age01 = age02 + age03;
age02++; //"++" increments a variable by one
age02--;//"--" decrements a variable by one

Console.WriteLine(age01 * age02);
Console.WriteLine();
Console.WriteLine(age02 / age01);
Console.WriteLine();
Console.WriteLine(age02 % age01);

// Console.WriteLine();
// Console.WriteLine(age02);
// Console.WriteLine();
// Console.WriteLine(age03);
// Console.WriteLine();

double interestRate = 0.0534;
double initialInvestment = 5000;
double finalInvestment;
finalInvestment = (initialInvestment * (1 + interestRate));
Console.Write("The investment after the investment period will be:");
Console.WriteLine(finalInvestment);

char xGameToken = 'x';
char oGameToken = 'o';

Console.WriteLine("The first game token is: " + xGameToken);
Console.WriteLine("The second game token is: " + oGameToken);

Console.WriteLine();
Console.WriteLine();