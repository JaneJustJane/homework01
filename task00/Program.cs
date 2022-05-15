Console.WriteLine("введите номер дня недели");
int a = int.Parse(Console.ReadLine() ?? "0");
if (a==1 || a==2||a==3 || a==4 || a==5)
Console.WriteLine("это будний день");
else if (a==6 || a==7)
Console.WriteLine("это выходной");
else if (a>7)
Console.WriteLine("в неделе 7 дней, введите число от 1 до 7");