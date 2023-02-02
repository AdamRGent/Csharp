
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata.Ecma335;
using static System.Console;

int x = 0;

while (x < 10)
{
    WriteLine(x);
   x++;
}

string? password;
int i = 0;

 do 
{
    Write("Enter your password: ");
    password = ReadLine();
    i++;
    if (password != "Pa$$w0rd" & i <=8)
    {
        WriteLine($"Incorrect Password, You have {10 - i} attempts remaining");
    }
    else if (password != "Pa$$w0rd" & i == 9)
    {
        WriteLine($"Incorrect Password, You have {10 - i} attempt remaining");
    }
    else if (i == 10)
    {
        WriteLine("Maximum attemps reachead!");
    }
    else if (password == "Pa$$w0rd")
    {
        WriteLine("Password Correct!");
    }
}
while (password != "Pa$$w0rd" && i <= 9); 



    /*if (i >= 9)
    {
        WriteLine("Maximum attemps reachead!");
    }
    else if (password == "Pa$$w0rd")
    {
        WriteLine("Password Correct!");
    }*/



for (int y = 1; y <= 10; y++)
{
    WriteLine(y);
}

string[] names = {"Adam", "Barry", "Charlie"};

foreach (string name in names)
{
    WriteLine($"{name} has {name.Length} characters.");
}
