using System;

class Program {

    public static void Main(string[] args)
    {
        Console.WriteLine("Please enter your grade?");
        int grade = Convert.ToInt32(Console.ReadLine());

        string x= grade >= 50 ? "pass" : "fail";

        Console.WriteLine(x);

    }
}