Console.WriteLine();
Console.WriteLine();

//Solutions Basic Programming Exercises doc.
#region Question02
// One acre of land is equivalent to 43,560 square feet. Write a program that calculates the
// number of acres in a tract of land with a user provided value of square feet.
//we name const variables using "Title case", sometimes called "Pascal case"
// const double NumberOfSquareFeetInAnAcre = 43560;

// double numberOfSquareFeet;

// string userAnswer;
// Console.Write("How many square feet are in the tract of land: ");
// userAnswer = Console.ReadLine();
// numberOfSquareFeet = double.Parse(userAnswer);
// double numAcres = numberOfSquareFeet / NumberOfSquareFeetInAnAcre;
// Console.WriteLine("The tract of land has: " + numAcres + " acres.");

#endregion

#region Question03
// A bag of cookies holds 26 cookies. The calorie information on the bag claims that there are 10
// servings in the bag and that each serving equals 175 calories. Write a program that lets the user
// enter the number of cookies he or she actually ate and then reports the number of total calories
// consumed.
//bag = 26 cookies
//servings in bag = 10
//serving = 175 calories
//I want calories per cookie.
//calories in bag = 175 * 10 = 1750
//calories per cooking = 1750/26

const double CookiesInBag = 26;
const double ServingsInBag = 10;
const double CaloriesInServing = 175;
const double CaloriesInBag = CaloriesInServing * ServingsInBag;
const double CaloriesPerCookie = CaloriesInBag / CookiesInBag;

Console.Write("How many cookies did you eat? No judgement. ");
double numCookiesEaten = double.Parse(Console.ReadLine());
double caloriesConsumed = numCookiesEaten * CaloriesPerCookie;
Console.WriteLine("You consumed " + caloriesConsumed);



#endregion
Console.WriteLine();
Console.WriteLine();