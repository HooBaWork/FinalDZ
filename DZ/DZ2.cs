//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Clear();
Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);


if (m > n)
{
    Console.WriteLine("Введите M меньше N");
}
FinalSumm(m, n);


void FinalSumm(int m, int n)
{
    Console.Write("Сумма натуральных элементов в промежутке от " + m + " до " + n + " : " +  Summ(m - 1, n));
}

int Summ(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + Summ(m, n);
        return res;
    }
}
