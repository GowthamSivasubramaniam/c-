using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
public class Runnable : Attribute { }
public class NotRunnable : Attribute
{

    // public int A { get; }
    // public NotRunnable(int a) { A = a; }
}

public class Task1
{
    [Runnable]
    public void SayHello()
    {
        Console.WriteLine("Task1: Hello from SayHello!");
    }
    [NotRunnable]
    public void NotRunnable()
    {
        Console.WriteLine("This won't be run because it's not marked.");
    }
}

public class Task2
{
    [Runnable]
    public void ShowDate()
    {
        Console.WriteLine($"Task2: Today's date is {DateTime.Now.ToShortDateString()}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Scanning for methods marked with [Runnable]...");


        Assembly currentAssembly = Assembly.GetExecutingAssembly();
        foreach (Type type in currentAssembly.GetTypes())
        {
            object? obj = Activator.CreateInstance(type);
            foreach (MethodInfo method in type.GetMethods())
            {
                if (method.GetCustomAttribute<Runnable>() != null)
                {
                    Console.WriteLine($"\nRunning: {type.Name}.{method.Name}");
                    method.Invoke(obj, null);
                }
                if (method.GetCustomAttribute<NotRunnable>() != null)
                {
                    Console.WriteLine($"\n[NotRunnable] Found: {type.Name}.{method.Name} ");
                    method.Invoke(obj, null);
                }
            }
        }

        Console.WriteLine("\nAll [Runnable] methods executed.");
    }
}

