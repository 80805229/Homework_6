// Задача 42: Определить, сколько чисел больше 0 введено с клавиатуры.

Console.Write("Введите количество чисел, вводимых с клавиатуры ");
int n = int.Parse(Console.ReadLine());

int[] num = new int[n];
Console.WriteLine("Введите числа");

int count = 0;

for (int i = 0; i < num.Length; i++)
{
    num[i] = int.Parse(Console.ReadLine());

    if (num[i] > 0)
    {
        count++;
    }
}
Console.WriteLine("Количество чисел больше 0 равно " + count);