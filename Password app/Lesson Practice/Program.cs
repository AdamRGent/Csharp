using System;
using System.Runtime.InteropServices;

class Public
{
    private static int i = 0;
   

    public static void Main(string[] args)
    {

        Console.WriteLine("Do you wish to create a new account?y/n");
        string? createAccount = Console.ReadLine();

        if (createAccount == "y")
        {
            Console.WriteLine("Please enter a Username:");
            string? Username = Console.ReadLine();
            
                Console.WriteLine("Please enter a Password:");
                string? Password = Console.ReadLine();
                do
                {
                    Console.WriteLine("Please re-enter the new Password:");
                string? passwordVerify = Console.ReadLine();
                if (passwordVerify == Password)
                {
                    Console.WriteLine("Account created");
                    break;
                }
                else
                {
                    Console.WriteLine("Passwords do not match");
                   
                   
                }
                } while (createAccount == "y");
            Console.WriteLine();
            Console.WriteLine("Do you wish to log in? y or n");
            string? logIn = Console.ReadLine();
            if (logIn == ("y"))
            {
                do
                {
                    i++;
                    Console.WriteLine("Please enter your username");
                    string? userNameCheck = Console.ReadLine();
                    Console.WriteLine("Please enter your password:");
                    string? passwordCheck = Console.ReadLine();

                    if (userNameCheck == Username && passwordCheck == Password)

                    {
                        Console.WriteLine($"Welcome {Username}, you have logged in");
                        break;
                    }
                    else if (i == 3)
                    {
                        Console.WriteLine("Maximum attempts exceeded");
                        break;
                    }


                    else
                    {
                        Console.WriteLine("Username and password is not correct");
                        Console.WriteLine($"{3 - i} attempts left");
                    }



                } while (logIn == "y");
            }
            else if (logIn != "y" && logIn != "n")
            {
                Console.WriteLine("Invalid Input, only enter y or n");

            }
            else
            {
                Console.WriteLine();

            }



        }
        else if (createAccount!="y" && createAccount!= "n") 
        {
            Console.WriteLine("Invalid input, please only enter y or n");
        }


    }
}