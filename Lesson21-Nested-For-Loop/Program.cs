class Program
{
    static void Main(string[] args)
    {
        #region simple nested loop

        for(int outer = 1; outer <= 10; outer++)
        {
            Console.Write($"Row #{outer}. ");
            for(int inner = 1; inner <= 10; inner++)
            {
                Console.Write($"{inner} ");
            }
            Console.WriteLine();
        }

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



        #endregion
    }
}