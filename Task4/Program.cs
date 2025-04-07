class Program
{
    public static void Main(string[] args)
    {
        List<Student> list = new List<Student>();

        while (true)
        {
            Console.WriteLine(" \nOptions \n\n  1 : Add new student \n  2 : Filter students with grade \n  3 : Exit \n");
            Console.Write("\nEnter Option : ");
            try{
            int input = Convert.ToInt32(Console.ReadLine());
            if (input < 1 || input > 3)
            {
                Console.WriteLine("Invalid option");
                Console.WriteLine("\n");
                continue;
            }
            
            int flag = 0;
            switch (input)
            {

                case 1:

                    Console.Write("\nEnter the Student Name: ");
                    string nameInput = Console.ReadLine() ?? string.Empty;

                    Console.Write("Enter the Age: ");
                    int age = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter the Grade (A/B/C...): ");
                    string gradeInput = (Console.ReadLine() ?? "").Trim().ToUpper();
                    char grade = gradeInput.Length > 0 ? gradeInput[0] : 'F';

                    Student s = new Student
                    {
                        name = nameInput,
                        age = age,
                        grade = grade
                    };

                    list.Add(s);
                    Console.WriteLine("Student Added Successfully\n"); break;
                case 2:

                    if (list.Count == 0)
                    {
                        Console.WriteLine("List is empty , add tasks...\n");

                    }
                    else
                    {
                        Console.Write("\nEnter the grade Threshold to filter:");
                         string gradeThres = (Console.ReadLine() ?? "").Trim().ToUpper();
                         char g = gradeThres.Length > 0 ? gradeThres[0] : 'F';
                        // var filter = from stu in list
                        //              where stu.grade < = g
                        //              orderby stu.grade
                        //              select stu;
                        var filter = list.Where(x => x.grade <= g);
                        filter = filter.OrderBy(x => x.name).ThenBy (x => x.grade);
                        foreach (var stu in filter)
                        {
                            Console.WriteLine(stu.name + "-" + stu.age + "-" + Convert.ToChar(stu.grade));
                        }

                    }
                    Console.WriteLine("\n");
                    break;

                case 3:
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