// Задача 46: Написать программу масштабирования фигуры

Console.WriteLine("Сколько вершин фигуры будет введено?");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("Введите коэффициент маштабирования");
double k = double.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine("Введите координаты точки " + i);
    double x = double.Parse(Console.ReadLine());
    double y = double.Parse(Console.ReadLine());
    Console.Write("Новые координаты точки после маштабирования " + i + " ");
    Console.Write(" (" + (x * k));
    Console.WriteLine("; " + (y * k) + ")");
}

