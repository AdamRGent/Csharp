using System;
using System.Runtime.CompilerServices;
using System.Security.Principal;

class Program
{
    private static string? password;
    private static string? userName;
    private static int count = 0;
    

    static void Main(string[] args)
    {
        Console.WriteLine("Do you already have an account? Please enter y for yes or n for no");
        string? answer = Console.ReadLine();
        if (answer == "n")
        {
            Console.WriteLine("Please create a username:");
            string? userName = Console.ReadLine();
            Console.WriteLine("Please create a password:");
            string? password = Console.ReadLine();
            Console.WriteLine("Please re-enter the password");
            string? passwordVerify = Console.ReadLine();
            if (password == passwordVerify)
            {
                Console.WriteLine("Account successfully created");

            }
            else
            {
                Console.WriteLine("Passwords did not match, please re-create a password and re-verify the password");
            }

            while (password != passwordVerify)
            {
                Console.WriteLine("Please create a password:");
                string? password1 = Console.ReadLine();
                Console.WriteLine("Please re-enter the password");
                string? passwordVerify2 = Console.ReadLine();
                if (password1 == passwordVerify2)
                {
                    Console.WriteLine("Account successfully created");
                    break;
                }
                else
                {
                    Console.WriteLine("Passwords did not match, please re-enter the password");
                }
            }
            Console.WriteLine();

            Console.WriteLine("Please enter your username to log in");
            string? verify = Console.ReadLine();
            Console.WriteLine("Please enter your password:");
            string? verify1 = Console.ReadLine();
            if (verify == "Admin" && verify1 == password)
            {
                Console.WriteLine($"Welcome {userName}, you have full access rights");
            }
            else if (verify == userName && verify1 == password)
            {
                Console.WriteLine($"Welcome {userName}, you have user access rights");
            }
            while (verify != userName || verify1 != password)
            {

                Console.WriteLine("Username or password incorrect");
                ++count;
                Console.WriteLine($"You have {3 - count} attempts remaining");
                if (count == 3)
                {
                    Console.WriteLine("Maximum attempts exceeded");
                    Console.WriteLine("Would you like to reset password: y or n?");
                    string? resetPassword = Console.ReadLine();
                    if (resetPassword == "y")
                    {
                        while (resetPassword == "y")
                        {
                            Console.WriteLine("Please enter your username:");
                            string? securityCheck = Console.ReadLine();

                            if (securityCheck == userName)

                            {
                                while (securityCheck == userName)

                                {

                                    Console.WriteLine("Please enter a new password:");
                                    string? newPassword = Console.ReadLine();
                                    Console.WriteLine("Please enter the new password again:");
                                    string? confirmPassword = Console.ReadLine();
                                    if (confirmPassword == newPassword)
                                    {
                                        Console.WriteLine("Password updated");
                                        Console.WriteLine();
                                        while (confirmPassword == newPassword)
                                        {
                                            Console.WriteLine("Please enter your ID:");
                                            string? userNamex = Console.ReadLine();


                                            Console.WriteLine("Please enter your new password to log in:");
                                            string? newPassword1 = Console.ReadLine();
                                            if (userNamex == userName && newPassword1 == newPassword)
                                            {
                                                Console.WriteLine($"Welcome {userName}, you have logged in");
                                                break;
                                                
                                            }
                                            else if (userNamex != userName || newPassword != newPassword1)
                                            {
                                                Console.WriteLine("Your Password or Username is incorrect, please try again");
                                            }

                                        }
                                        break;
                                    }
                                    else if (confirmPassword != newPassword)
                                    {
                                        Console.WriteLine("Passwords do not match");

                                    }
                                  
                                }
                                break;
                            }


                            else
                            {
                                Console.WriteLine("Username incorrect");
                                
                            }
                            
                        }
                    }

                    else

                    {
                     break;
                    }
                 break;
                }
                Console.WriteLine();
                Console.WriteLine("Please enter your username:");
                string? verify2 = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Please enter your password:");
                string? verify3 = Console.ReadLine();
                if (verify2 == "Admin" && verify3 == password)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Welcome {userName}, you have full access rights");
                    break;

                }
                else if (verify2 == userName && verify3 == password)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Welcome {userName}, you have user access rights");
                    break;

                }
                else
                {

                    Console.WriteLine();

                }


            }

        }
        else if (answer == "y")
        {
            Console.WriteLine("Please enter your username to log in");
            string? verify = Console.ReadLine();
            Console.WriteLine("Please enter your password:");
            string? verify1 = Console.ReadLine();
            if (verify == "Admin" && verify1 == password)
            {
                Console.WriteLine($"Welcome {userName}, you have full access rights");
            }
            else if (verify == userName && verify1 == password)
            {
                Console.WriteLine($"Welcome {userName}, you have user access rights");
            }
            while (verify != userName || verify1 != password)
            {

                Console.WriteLine("Username or password incorrect");
                ++count;
                Console.WriteLine($"You have {3 - count} attempts remaining");
                if (count == 3)
                {
                    Console.WriteLine("Maximum attempts exceeded");
                    break;
                }
                Console.WriteLine();
                Console.WriteLine("Please enter your username:");
                string? verify2 = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Please enter your password:");
                string? verify3 = Console.ReadLine();
                if (verify2 == "Admin" && verify3 == password)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Welcome {userName}, you have full access rights");
                    break;

                }
                else if (verify2 == userName && verify3 == password)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Welcome {userName}, you have user access rights");
                    break;

                }
                else
                {

                    Console.WriteLine();

                }
            }
        }
    }
}
  

            