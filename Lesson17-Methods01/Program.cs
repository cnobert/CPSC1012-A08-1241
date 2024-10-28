Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");

#region basics of a C# method
double firstNum = 40, secondNum = 50;
double theSum = firstNum + secondNum;
Console.WriteLine($"The answer is {theSum}.");

Console.WriteLine($"The sum of adding {40.2} and {50.8} is: {AddTogetherDoubles(40.2, 50.8)}.");
Console.WriteLine($"The product of multiplying {40.2} and {50.8} is: {MultiplyTogetherDoubles(40.2, 50.8)}.");


//adds together two doubles and returns their sum
static double AddTogetherDoubles(double number01, double number02)
{
    double theSum = number01 + number02;
    return theSum;
}


//multiplies two doubles and returns their product
static double MultiplyTogetherDoubles(double number01, double number02)
{
    double theProduct = number01 * number02;
    return theProduct;
}
#endregion

// double initialInvestmentAmount = -1;
// Console.Write("Enter the initial amount you want to invest: ");
// //wouldn't it be nice to just reuse some old code to get the investment amount?
// initialInvestmentAmount = GetDoubleAboveZero();

Console.WriteLine("Let's add together three positive numbers.");
// double num01 = GetDoubleAboveZero();
// double num02 = GetDoubleAboveZero();
// double num03 = GetDoubleAboveZero();
// Console.WriteLine($"The numbers, added together, equal {num01 + num02 + num03}");

// Console.WriteLine($"The numbers, added together, equal {GetAndAddThreeDoubles()}");
Console.WriteLine($"The numbers, added together, equal {GetDoubleAboveZero() + GetDoubleAboveZero() + GetDoubleAboveZero()}");

static double GetAndAddThreeDoubles()
{
    // double num01 = GetDoubleAboveZero();
    // double num02 = GetDoubleAboveZero();
    // double num03 = GetDoubleAboveZero();
    return GetDoubleAboveZero() + GetDoubleAboveZero() + GetDoubleAboveZero();
}

static double GetDoubleAboveZero()
{
    double investment = -1;
    do
    {
        try
        {
            Console.Write("Enter a number greater than zero: ");
            investment = double.Parse(Console.ReadLine());
            if (investment <= 0)
            {
                //they entered a valid number, but it's not greater than 0
                Console.Write("Please enter a number greater than zero. Try again: ");
            }
        }
        catch
        {
            Console.Write("Please enter a valid number. Try again: ");
        }
    }
    while (investment <= 0);
    return investment;
}
