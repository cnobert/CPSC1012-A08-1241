 
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
        
        const int ArrayLength = 5;
        string fileName = "studentData.txt";
        //in the assignment this would be daysOfMonth
        string[] studentNames = new string[ArrayLength]; 
        //in the assignment this would be salesForDay
        int[] studentMarks = new int[ArrayLength];
        
        //loading logicalSize, studentNames, and studentMarks with test data
        int logicalSize = 3;
        // studentNames[0] = "Conrad Nobert";
        // studentNames[1] = "Taylor Fast";
        // studentNames[2] = "Brinda Kaur";

        // studentMarks[0] = 30;
        // studentMarks[1] = 98;
        // studentMarks[2] = 79;
        //FileWrite(studentNames, studentMarks, logicalSize, fileName);
        logicalSize = FileRead(studentNames, studentMarks, fileName);
        for(int c = 0; c < logicalSize; c++)
        {
            Console.WriteLine($"{studentNames[c]} {studentMarks[c]}");
        }

    }
    static int FileRead(string[] studentNames, int[] studentMarks, string fileName)
    {
        int logicalSize = 0;
        Console.WriteLine("-----Reading from file-----");

        StreamReader reader = null;
        if(File.Exists(fileName))
        {
            try
            {
                reader = new StreamReader(fileName);

                //priming read
                reader.ReadLine();
                while(!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    //"Conrad Nobert, 30"
                    studentNames[logicalSize] = line.Substring(0, line.IndexOf(","));
                    string restOfLine = line.Substring(line.IndexOf(",") + 1);
                    studentMarks[logicalSize] = int.Parse(restOfLine);
                    logicalSize++;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Something went wrong: {e.Message}");
            }
        }

        Console.WriteLine("-----File read!-----");
        return logicalSize;
    }
    static void FileWrite(string[] studentNames, int[] studentMarks, int logicalLength, string fileName)
    {
        StreamWriter writer = null;
        Console.WriteLine("-----Writing to file-----");
        try
        {
            writer = new StreamWriter(fileName);
            writer.WriteLine("Name, Mark");
            for(int c = 0; c < logicalLength; c++)
            {
                writer.WriteLine($"{studentNames[c]},{studentMarks[c]}");
            }
            writer.Close();
        }
        catch(Exception e)
        {
            Console.WriteLine($"Something went wrong: {e.Message}");
        }
        Console.WriteLine("-----File written!-----");
    }

}