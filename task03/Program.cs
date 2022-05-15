Console.WriteLine("введите координаты (x1,y1,z1) первой точки");
int x1 = int.Parse(Console.ReadLine() ?? "0");
int y1 = int.Parse(Console.ReadLine() ?? "0");
int z1 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("введите координаты (x2,y2,z2) второй точки");
int x2 = int.Parse(Console.ReadLine() ?? "0");
int y2 = int.Parse(Console.ReadLine() ?? "0");
int z2 = int.Parse(Console.ReadLine() ?? "0");

double a = Math.Sqrt(((x2-x1)*(x2-x1))+((y2-y1)*(y2-y1))+((z2-z1)*(z2-z1)));
Console.WriteLine ("расстояние между точками:");
Console.WriteLine (a);
