// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Clear();
Console.Write("Введите число M:");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N:");
int m = int.Parse(Console.ReadLine()!);
static int FunctionAccerman(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return FunctionAccerman(n - 1, 1);
    else
        return FunctionAccerman(n - 1, FunctionAccerman(n, m - 1));
}
 
Console.WriteLine(FunctionAccerman(n, m));
