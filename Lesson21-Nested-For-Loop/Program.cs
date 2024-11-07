using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        #region simple nested loop

        // for(int outer = 1; outer <= 10; outer++)
        // {
        //     Console.Write($"Row #{outer}. ");
        //     for(int inner = 1; inner <= 10; inner++)
        //     {
        //         Console.Write($"{inner} ");
        //     }
        //     Console.WriteLine();
        // }

        #endregion
    
        #region chart example

        const int ArraySize = 30;
        int logicalSize = 20;
        //20 names
        string[] names = { "Akira", "Beatriz", "Chen", "Dmitri", "Elena", "Fatima", "Giovanni", "Hiroshi", "Isabel", "Javier", "Khaled", "Leila", "Ming", "Nina", "Omar", "Priya", "Ravi", "Sofia", "Tomoko", "Youssef" };
        int[] favouriteNumbers = new int[ArraySize];

        //loads up the favouriteNumbers array with random values between 1 and 500
        Random random = new Random();
        for (int c = 0; c < logicalSize; c++)
        {
            favouriteNumbers[c] = random.Next(1, 500); 
        }

        for (int c = 0; c < logicalSize; c++)
        {
            Console.WriteLine($"{names[c]} has favourite number {favouriteNumbers[c]}.");
        }

        //algorithm to find the max number in this array
        int maxFavouriteNumber = favouriteNumbers[0];
        for(int c = 0; c < logicalSize; c++)
        {
            if(favouriteNumbers[c] > maxFavouriteNumber)
            {
                maxFavouriteNumber = favouriteNumbers[c];
            }
        }
        Console.WriteLine($"The max number in the favouriteNumbers array is {maxFavouriteNumber}");

        //find the nearest "10" above the max number
        int closest10AboveMaxFavouriteNumber = (int)Math.Ceiling(maxFavouriteNumber / 10.0) * 10;
        Console.WriteLine($"The max number, rounded to the nearest 10, is {closest10AboveMaxFavouriteNumber}");

        //output the chart
        for(int outer = closest10AboveMaxFavouriteNumber; outer >= 0; outer -= 10)
        {
            //outer loop controls the rows
            Console.Write(outer + "|\t");
            //inner loop will go here and check if there are numbers that belong in this row
            for(int inner = 0; inner < logicalSize; inner++)
            {
                int num = favouriteNumbers[inner];
                if(num > outer - 10 && num <= outer)
                {
                    Console.Write(num);
                }
                else
                {
                    Console.Write("\t");
                }
            }
            Console.WriteLine();
        }
        Console.Write("\n\t");
        for(int c = 0; c < logicalSize; c++)
        {
            Console.Write(names[c] + "\t");
        }

        #endregion
    }
}