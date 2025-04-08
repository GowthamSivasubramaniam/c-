
class Program
{
    public delegate void displayevent(string s);
    public static event displayevent counterevent;
    public static void handlecount(string c)
    {
        Console.WriteLine("Counter Event Triggered , count => "+c);
    }
    public static void handlecountmod(string c)
    {
        int a = Convert.ToInt32(c);
        Console.WriteLine("Additional handler that performs Mod 4 operation : " + a%4);
    }

    public static void Main(string[] args)
    {  

        // counterevent += handlecountmod;
        checking c1 = new checking();
        checking1 c2 = new checking1();

        c1.disp();
        c2.disp();

      
        
         int c=0;
         for(int i=0;i<=34;i++)
         {
            c+=1;

            if(c%3==0)
            {
              
                counterevent?.Invoke(Convert.ToString(c));
            }
            else
            {
                Console.WriteLine("count : "+c);
            }
         }
    }
}

class checking
{
    private Program.displayevent p ;
     public  void disp()
     {
        p+=handlecountmod1;
        Program.counterevent +=p;
     }
     public static void handlecountmod1(string c)
    {
        int a = Convert.ToInt32(c);
        Console.WriteLine("Additional handler from checking that performs Mod 5 operation :" + a%5);
    }
}

class checking1
{
    private Program.displayevent p ;
     public  void disp()
     {
        p += Program.handlecount;
        p +=handlecountmod2;
        Program.counterevent +=p;
        
     }
     public static void handlecountmod2(string c)
    {
        int a = Convert.ToInt32(c);
        Console.WriteLine("Additional handler from checking1 that performs Mod 6 operation : " + a%6);
        
    }
}