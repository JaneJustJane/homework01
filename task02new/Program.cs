Console.WriteLine("введите номер плоскости");
int a = int.Parse(Console.ReadLine() ?? "0");
if (a==1)
Console.WriteLine ("I четверть! (x>0,y>0)");
if (a==2)
Console.WriteLine ("II четверть! (x<0,y>0)");
if (a==3)
Console.WriteLine ("III четверть! (x<0,y<0)");
if (a==4)
Console.WriteLine ("IV четверть! (x>0,y<0)");
if (a<=0 || a>4)
Console.WriteLine ("Введите номер от 1 до 4!");