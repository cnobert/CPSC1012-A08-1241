
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
        #region method signatures and overloading
        // Console.WriteLine($"50 + 100 = {AddNumbers(500, 103434)}");
        // Console.WriteLine($"50 + 100 = {AddNumbers(2342, 103434)}");
        // Console.WriteLine($"50 + 100 + 1000 = {AddNumbers(50, 100, 1000)}");
        // Console.WriteLine($"50.2 + 100.8 + 1000 = {AddNumbers(50.2, 100.8, 1000)}");
        #endregion

        #region pass by value and pass by reference
        // double num01 = 45.4;
        // double num02 = 51;
        // Console.WriteLine($"The answer is: {AddNumbers(num01, num02)}");
        // Console.WriteLine($"num01 is equal to {num01}");

        // double[] numbers = new double[2];
        // numbers[0] = 33.1;
        // numbers[1] = 12.9;
        // Console.WriteLine($"The answer is: {AddNumbers(numbers)}");
        // Console.WriteLine($"num01 is equal to {numbers[0]}");
        #endregion

        #region Question 1, Method Problems 1
        PrintMenu();
        Console.Write("How old are you? ");
        double age = GetDoubleAboveZero();
        Console.WriteLine($"Your price of admission is: {GetTicketPrice(age)}");

        #endregion
    }
    static double GetTicketPrice(double theAge)
    {
        //do the logic for getting a ticket price
        double price = 10;;
        if(theAge <= 6)
        {
            price = 0;
        }
        else if(theAge < 18)
        {
            price = 9.80;
        }
        else if(theAge < 55)
        {
            price = 11.35;
        }
        return price;
    }
    static int GetIntAboveZero()
    {
        return (int) GetDoubleAboveZero();
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
    static void PrintMenu()
    {
         Console.WriteLine("Children 6 and under = FREE ($0.00)\n" +
                        "Students 7 to 17 = $9.80\n" +
                        "Adults 18 to 54 = $11.35\n" +
                        "Seniors 55+ = $10.0");
    }
    

    static double AddNumbers(double[] numbers)
    {
        numbers[0] = 10000;
        return numbers[0] + numbers[1];
    }
    
    static double AddNumbers(double num01, double num02)
    {
        num01 = 10000;
        return num01 + num02;
    }
    static double AddNumbers(double num01, double num02, double num03)
    {
        //return AddNumbers(AddNumbers(num01, num02), num03);
        return num01 + num02 + num03;
    }
    static int AddNumbers(int num01, int num02, int num03)
    {
        return num01 + num02 + num03;
    }

}
