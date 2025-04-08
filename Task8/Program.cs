public interface IRrepo<T>
{
    public void Add(T item);
    public void Removeitem(int id);

    public IEnumerable<T> GetItems();

}

public class Repo<T> : IRrepo<T> where T : class
{
    private readonly List<T> items = new List<T>();

    public void Add(T item)
    {
        items.Add(item);
    }
    public void Removeitem(int id)
    {
        items.RemoveAt(id);
            Console.WriteLine("Removed item");

    }
    public IEnumerable<T> GetItems()
    {
        return items;
    }
}

public class Product
{
    public string? name { get; set; }
    public int price { get; set; }
}

public class Program
{
    static void Main(string[] args)
    {
        Repo<Product> repo = new Repo<Product>();
        while (true)
        {
            Console.WriteLine(" \nOptions \n\n  1 : Add new Product \n  2 : Remove product with id \n  3 : Display products \n  4 : Exit \n");
            Console.Write("\nEnter Option : ");
            try
            {
                int input = Convert.ToInt32(Console.ReadLine());
                if (input < 1 || input > 4)
                {
                    Console.WriteLine("Invalid option");
                    Console.WriteLine("\n");
                    continue;
                }

                int flag = 0;
                switch (input)
                {

                    case 1:

                        Console.Write("\nEnter the Product Name: ");
                        string nameInput = Console.ReadLine() ?? string.Empty;

                        Console.Write("Enter the Price: ");
                        int price = Convert.ToInt32(Console.ReadLine());

                        repo.Add(new Product { name = nameInput, price = price });
                        Console.WriteLine("Product Added Successfully\n"); break;
                    case 2:
                         IEnumerable<Product> products1 = repo.GetItems();
                        if (!products1.Any())
                        {

                            Console.WriteLine("No products to Remove .. Add Products\n");
                            
                        }
                        else
                        {
                            Console.Write("\nEnter the id:");
                            int id = Convert.ToInt32(Console.ReadLine());
                            repo.Removeitem(id);
                        }
                        Console.WriteLine("\n");
                        break;
                    case 3:
                        
                        IEnumerable<Product> products = repo.GetItems();
                        if (!products.Any())
                        {
                            Console.WriteLine("No products to show .. Add Products\n");

                        }
                        else
                        {
                            int index=0;
                        foreach (var item in products)
                        {
                            Console.WriteLine($" Id: {index++} Item :{item.name} - Rs.{item.price}");
                        }
                        }
                        break;

                    case 4:
                        flag = 1;
                        Console.WriteLine("\nThank You\n");
                        break;

                }

                if (flag == 1)
                    break;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Enter valid Option");
            }
        }

    }
}