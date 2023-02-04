/*Задача 34: 
Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

Console.Write("Введите длину массива = ");
int x = Convert.ToInt32(Console.ReadLine());
int[] num = new int[x];
for (int i = 0; i < num.Length; i++)
    num[i] = new Random().Next(100, 1000);
int NoNs = 0;
for (int i = 0; i < num.Length; i++)
{

    if (num[i] % 2 == 0)
    {
        NoNs ++;
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
Console.WriteLine($"Количество четных элементов массива -> {NoNs}");