class Program
{
    public static void Main(string[] args)
    {
        List<string> list = new List<string>();
        while (true)
        {
            Console.WriteLine(" \nOptions \n\n  1 : Add new task \n  2 : Enter id to Remove task \n  3 : Display Tasks \n  4 : Exit \n");
            Console.Write("\nEnter Option : ");
            int input = Convert.ToInt32(Console.ReadLine());
            if ( input < 1 || input > 4)
            {
                Console.WriteLine("Invalid option");
                Console.WriteLine("\n");
                continue;
            }
            int flag = 0;
            switch (input)
            {

                case 1:

                    Console.Write("\nEnter the Task : ");
                    string task = new string(Console.ReadLine());
                    list.Add(task.Trim());
                    Console.WriteLine("Task Added Successfully\n");
                    Console.WriteLine("\n");
                    break;

                case 2:

                    if (list.Count == 0)
                    {
                        Console.WriteLine("List is empty , add tasks...\n");

                    }
                    else
                    {
                        Console.Write("\nEnter the Task id you want to remove :");
                        int id = Convert.ToInt32(Console.ReadLine());
                        list.RemoveAt(id);
                        Console.WriteLine("Task " + id + " removed Successfully\n");


                    }
                    Console.WriteLine("\n");
                    break;

                case 3:

                    if (list.Count == 0)
                        Console.WriteLine("Nothing to show!! Add Tasks\n");
                    for (int i = 0; i < list.Count; i++)
                    {
                        Console.WriteLine("Task id : " + i + " task : " + list[i]);
                    }
                    Console.WriteLine("\n");
                    break;

                case 4:

                    flag = 1;
                    Console.WriteLine("\nThank You\n");
                    break;

            }

            if (flag == 1)
                break;

        }



    }
}