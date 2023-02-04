/*Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

Console.Write("Введите длину массива = ");
int x = Convert.ToInt32(Console.ReadLine());
int[] num = new int[x];
for (int i = 0; i < num.Length; i++)
    num[i] = new Random().Next(0, 100);
int SumOddPositions = 0;
for (int i = 0; i < num.Length; i++)
{

    if (i % 2 == 0)
    {
        SumOddPositions = SumOddPositions + num[i];
    }

}
Console.Write("[");
for (int i = 0; i < num.Length; i++)
{
    if (i < num.Length - 1)
    {
        Console.Write($"{num[i]}, ");
    }
    else
    {
        Console.Write($"{num[i]}");
    }
}
Console.Write("] -> это наш массив");
Console.WriteLine();
Console.WriteLine($"суммa элементов, стоящих на нечётных позициях -> {SumOddPositions}");