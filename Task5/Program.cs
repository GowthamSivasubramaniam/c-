
class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter input file path: ");
            string? inputPath = Console.ReadLine() ;

            if (!File.Exists(inputPath))
                throw new FileNotFoundException("Input file not found.");

            string[] lines = File.ReadAllLines(inputPath);
            int lineCount = lines.Length;
            int wordCount = 0;

            foreach (var line in lines)
                wordCount += line.Split(',').Length;

            string result = $"Lines: {lineCount}, Words: {wordCount}";
            Console.WriteLine(result);

            string outputPath = "result.txt";
            File.WriteAllText(outputPath, result);
            Console.WriteLine($"Result written to {outputPath}");
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (IOException ex)
        {
            Console.WriteLine("File error: " + ex.Message);
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine("Permission error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unexpected error: " + ex.Message);
        }
    }
}
