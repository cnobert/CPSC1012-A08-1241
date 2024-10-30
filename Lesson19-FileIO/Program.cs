
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");

        string fileName = "numbers.txt";
        
        const int NumLinesInFile = 5;
        string[] fileLines = new string[NumLinesInFile];

        ReadFromFile(fileName, fileLines);
        WriteToFile(fileName, NumLinesInFile);
        for(int c = 0; c < fileLines.Length; c++)
        {
            Console.WriteLine(fileLines[c]);
        }
    }

    static void ReadFromFile(string theFileName, string[] fileLines)
    {
        StreamReader reader = null;

        if(File.Exists(theFileName))
        {
            try
            {
                reader = new StreamReader(theFileName);
                int fileLineCounter = 0;
                while(!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if(fileLineCounter < fileLines.Length)
                    {
                        fileLines[fileLineCounter] = line;
                        fileLineCounter++;
                    }
                }
                reader.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine($"Something went wrong: {e.Message}");
            }
        }
    }

    static void WriteToFile(string fileName, int numberOfLinesToWrite)
    {
        StreamWriter writer = null;
        Console.WriteLine("Writing file numbers.txt");
        try
        {
            writer = new StreamWriter(fileName);
            for(int c = 0; c < numberOfLinesToWrite; c++)
            {
                writer.WriteLine($"the number: {c + 1}");
            }
            writer.Close();
        }
        catch(Exception e)
        {
            Console.WriteLine($"Something went wrong: {e.Message}");
        }
    }
}