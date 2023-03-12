//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.Clear();
Console.Write("Введите число M:");
int N = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N:");
int M = int.Parse(Console.ReadLine()!);
if (M > N)
{
    for (int i = N; i <= M; i++)
    Console.Write($" {i}");
}
else
{
for (int i = M; i <= N; i++)
Console.Write($" {i}");
}
