// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, если b1, k1, b2 и k2 заданы

Console.Write("Введите b1 ");
double b1 = double.Parse(Console.ReadLine());
Console.Write("Введите k1 ");
double k1 = double.Parse(Console.ReadLine());

Console.Write("Введите b2 ");
double b2 = double.Parse(Console.ReadLine());
Console.Write("Введите k2 ");
double k2 = double.Parse(Console.ReadLine());

if (k1 == k2)
{
    if (b1 == b2)
    {
        Console.WriteLine("Линии пересекаются ");

    }
}
else
{
    double x = (b2 - b1) / (k1 - k2);
    Console.WriteLine("Координаты точки х - " + x);

    double y = k1 * x + b1;
    Console.WriteLine("Координаты точки y - " + y);
}
