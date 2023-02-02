using static System.Console;
using static System.Convert;

int a = 10;
double b = a; //an int can be safely cast into a double
WriteLine(b);

double c = 9.8;
int d = (int)c; // d is 9 losing the .8 part, () is a cast operator 
WriteLine(d);

long e = 10;
int f = (int)e;// converting a larger integer to a smaller integer
WriteLine($"e is {e:N0} and f is {f:N0}");
e = long.MaxValue;
f = (int)e;
WriteLine($"e is {e:N0} and f is {f:N0}");

double g = 9.8;
int h = ToInt32(g); // a method of System.Convert, coverting rounds the number rather than removing after the decimal
WriteLine($"g is {g} and h is {h}");    