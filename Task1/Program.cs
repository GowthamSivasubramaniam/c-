using System;
using System.Numerics;

class Program 
{
    static void Main()
    {   
        Console.WriteLine("This a Factorial Calculator . If you want end the Calculation enter -1");
        while(true)
        {
        
        Console.Write("Enter a Number : ");
        try
        {
        int number = Convert.ToInt32(Console.ReadLine());
        if(number >=0)
        {
            if(number>=0 && number <=1)
            {
                Console.WriteLine("The factorial of "+ number +" is :1");
            }
            else
            {   
                BigInteger fact =1;
                for(long i=2;i<=number;i++)
                {
                     fact*=i;
                }
                Console.WriteLine("The factorial of "+ number +" is :"+fact);
            }

        }
        else
        {
            Console.WriteLine("Thankyou");
            break;
        }
        }
        catch (FormatException)
            {
                Console.WriteLine("Please enter a valid integer (no floating-point numbers).");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Number is too large! Please enter a smaller integer.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"An unexpected error occurred: {e.Message}");
            }
        }

    }
}

