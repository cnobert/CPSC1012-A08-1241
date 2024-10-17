Console.WriteLine("\n\n\n\n\n\n\n\n\n\n");

const double BaseCostA = 9.95;
const double BaseCostB = 13.95;
const double BaseCostC = 19.95;

const double HourlyCostA = 2.00;
const double HourlyCostB = 1;

const double ThresholdA = 10;
const double ThresholdB = 20;

char continueYN = 'n';
char internetPackage;
int hoursUsed = 0;
double totalCost = 0.0;
do
{
    
    do
    {
        Console.Write("\nEnter the package letter (A, B, or C): ");
        internetPackage = char.ToUpper(Console.ReadKey().KeyChar);
    } while(internetPackage != 'A' && internetPackage != 'B' && internetPackage != 'C');
    
    bool validInput = false;
    switch(internetPackage)
    {
        case 'A':
            do
            {
                try
                {
                    Console.Write("\nYou selected Package A. Now enter the hours used: ");
                    hoursUsed = int.Parse(Console.ReadLine());
                    validInput = true;
                }
                catch(Exception e)
                {
                    Console.WriteLine($"Oops, {e.Message}, try again.");
                }
            } while(validInput == false); //while(!validInput);

            //We have the package and the number of hours. Calculations may commence.
            if(hoursUsed > ThresholdA)
            {
                totalCost = (hoursUsed - ThresholdA) * HourlyCostA + BaseCostA;
            }
            else
            {
                totalCost = BaseCostA;
            }
            break;
        case 'B':
            do
            {
                try
                {
                    Console.Write("\nYou selected Package B. Now enter the hours used: ");
                    hoursUsed = int.Parse(Console.ReadLine());
                    validInput = true;
                }
                catch(Exception e)
                {
                    Console.WriteLine($"Oops, {e.Message}, try again.");
                }
            } while(validInput == false); //while(!validInput);

            //We have the package and the number of hours. Calculations may commence.
            if(hoursUsed > ThresholdB)
            {
                totalCost = (hoursUsed - ThresholdB) * HourlyCostB + BaseCostB;
            }
            else
            {
                totalCost = BaseCostB;
            }
            break;
        case 'C':
            totalCost = BaseCostC;
            break;
        default:
            break;
    }

    Console.WriteLine($"\nThe total cost of the internet package is {totalCost:c}");
    do
    {
        Console.Write("\nWould you like to run this program again? [y/n]");
        continueYN = char.ToLower(Console.ReadKey().KeyChar);
    } while(continueYN != 'y' && continueYN != 'n');
} while(continueYN != 'n');

Console.WriteLine("\n\nGoodbye.\n\n");

//how to get a random value between 1.3 and 1.9
Random rando = new Random();
const double Min = 1.3;
const double Max = 1.9;
double theRandomNumber = 1.4; //min + rando.NextDouble() * (max - min);
Console.WriteLine($"Here's a random number between {Min} and {Max}: {theRandomNumber:n}");