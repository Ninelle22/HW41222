// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

using static System.Console;

WriteLine($"{GetStringNumbersRecur(Input("m"), Input("n"))}\"\"");

int Input(string text)

{
    WriteLine($"Enter number { text }: ");
    int number = int.Parse(ReadLine()!);
    return number;
}

string GetStringNumbersRecur(int m, int n)
{
    if (m == n) return $"{n}";
    if (m > n) return $"{m}" + GetStringNumbersRecur(m-1, n);
    return $"{n}," + GetStringNumbersRecur(n-1, m);
}
