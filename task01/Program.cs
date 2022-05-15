Console.WriteLine("введите два числа");
int a = int.Parse(Console.ReadLine() ?? "0");
int b = int.Parse(Console.ReadLine() ?? "0");
if (a==b*b || b==a*a)
Console.WriteLine("одно из чисел является квадратом второго");
else Console.WriteLine("одно из чисел не является квадратом второго");