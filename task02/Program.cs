Console.WriteLine("введите координату Х");
int x = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("введите координату Y");
int y = int.Parse(Console.ReadLine() ?? "0");

if (x>0 && y>0)
Console.WriteLine ("I четверть! (x>0,y>0)");
if (x<0 && y>0)
Console.WriteLine ("II четверть! (x<0,y>0)");
if (x<0 && y<0)
Console.WriteLine ("III четверть! (x<0,y<0)");
if (x>0 && y<0)
Console.WriteLine ("IV четверть! (x>0,y<0)");