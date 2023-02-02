using static System.Console;
string password = "ninja";

if (password.Length < 8)
{
    WriteLine("Your password is too short. Use at least 8 characters.");
}
else
{
    WriteLine("Your password is too strong");
}

// add and remove the "" to change the behaviour

object o = "3";
int j = 4;

if (o is int i)
{
    WriteLine($"{i} x {j} = {i * j}");
}
else
{
    WriteLine("o is not an int so it cannot multiple!");
}

int number = (new Random()).Next(1, 7); //generates random number between 1 and 6, 7 is an exclusive upper bound
WriteLine($"My random number is {number}");

switch (number)
{
    case 1:
        WriteLine("One");
        break; // jumps to end of switch statement
    case 2:
        WriteLine("Two");
        goto case 1;
    case 3: //multiple case section
    case 4:
        WriteLine("Three or Four");
        goto case 1;
    case 5:
        goto A_label;
    default:
        WriteLine("Default");
        break;
}// end of switch statement

WriteLine("After end of switch");
A_label:
WriteLine($"After A_label");

string path = @"C:\Code\Chapter03";

Write("Press R for read-only or W for writeable: ");
ConsoleKeyInfo key = ReadKey();
WriteLine();

Stream? s;

if (key.Key == ConsoleKey.R)
{
    s = File.Open(
        Path.Combine(path, "file.txt"),
        FileMode.OpenOrCreate,
        FileAccess.Read);
}
else
{
    s = File.Open(
       Path.Combine(path, "file.txt"),
       FileMode.OpenOrCreate,
       FileAccess.Write);
}

string message;

switch (s)
{
    case FileStream writeableFile when s.CanWrite:
        message = "The stream is a file that can write to.";
        break;
    case FileStream readOnlyFile:
        message = "The stream is a read-only file.";
        break;
    case MemoryStream ms:
        message = "The string is args memory address.";
        break;
    default: //always evaluated last despite it's current position
        message = "The stream is some other type.";
        break;
    case null:
        message = "The stream is null.";
        break;
}

Write(message);
