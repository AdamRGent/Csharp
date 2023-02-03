using System;
using System.Linq.Expressions;

class Program
{

    public static void Main(string[] args)
    {
        try { 
              Console.WriteLine("Please enter your grade?");
              int grade = Convert.ToInt32(Console.ReadLine());
            

                switch (grade)
                {
                    case >100:
                              Console.WriteLine("Maximum input is 100");
                              break;

                    case >= 80:
                              Console.WriteLine("You have passed with Distinction");
                              break;

                    case >= 60:
                              Console.WriteLine("You have passed with Merit");
                              break;

                    case >= 50:
                              Console.WriteLine("You have Passed");
                              break;

                    default:
                              Console.WriteLine("You have Failed");
                              break;
                }
            }

        catch(Exception ex)
            {
                Console.WriteLine("You can only enter digits");
            }
    }
}