/*Задача 38:
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным 
элементов массива.

[3 7 22 2 78] -> 76
*/

Console.Write("Введите длину массива = ");
int x = Convert.ToInt32(Console.ReadLine());
double[] num = new double[x];
Random rand = new Random();
for (int i = 0; i < num.Length; i++)
{
    num[i] = rand.Next(-100, 100) + rand.NextDouble();
}
double DiffMinMax = 0;
double min = num[0], 
    max = num[0];
for (int i = 1; i < num.Length; i++)
{

    if (num[i] < min )
    {
        min = num[i];
    }
    else if (num[i] > max)
    {
        max = num[i];
    }

}
Console.Write("[");
DiffMinMax = max - min;
for (int i = 0; i < num.Length; i++)
{
    if (i < num.Length - 1)
    {
        Console.Write($"{Math.Round(num[i], 2)}; ");
    }
    else
    {
        Console.Write($"{Math.Round(num[i], 2)}");
    }
}
Console.Write("] -> это наш массив");
Console.WriteLine();
Console.WriteLine($"разницу между максимальным и минимальным элементов массива -> {Math.Round(DiffMinMax, 2)}");