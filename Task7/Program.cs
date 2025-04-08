

class Program
{
     static async Task Main(string[] args)
    {  
        Console.Write("Enter a number :");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter a number :");
        double b =  Convert.ToDouble(Console.ReadLine());
        Task add = Add(a,b);
        Task sub = Sub(a,b);
        Task div = Divide(a,b);
        await Task.WhenAll(add, sub,div);
        Console.WriteLine("Completed all the tasks");
    }

    static async Task Add(double a, double b)
    {
        await Task.Delay(1000);
        Console.WriteLine($"Addition: {a + b}");
    }
    static async Task Sub(double a, double b)
    {
        await Task.Delay(100);
        Console.WriteLine($"Subtraction: {a - b}");
    }
    static async Task Divide(double a, double b)
    {
        await Task.Delay(100);
        try{
            if(b==0)
            throw new DivideByZeroException();
        Console.WriteLine($"Division: {a/b}");
        }
        catch(DivideByZeroException ex)
        {
            Console.WriteLine("Divisor cannot be zero");
        }
    }
}
