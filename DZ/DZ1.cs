//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.Clear();
Console.Write("Введите число n:");
int n = int.Parse(Console.ReadLine()!);
string getNumber(int n)
{   
    if(n == 1) return "1";
    else
    {
        Console.Write("{0} ", n);
        return getNumber(n - 1);
    }
}
Console.WriteLine(getNumber(n));
