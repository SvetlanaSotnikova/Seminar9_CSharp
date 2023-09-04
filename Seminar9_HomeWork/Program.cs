// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
/*
string WriteArr(int num, string result)
{
    if (num == 1)
    {
        result = result + " " + '1';
        return result;
    }
    else
    {
        result = result + " " + num;
        return WriteArr(num - 1, result);
    }
}
string result = "";
Console.Write("input the number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write($"N = {num} -> {WriteArr(num, result)}");
*/

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
/*
int SumNaturalDigits(int start, int end)
{
    if (start > end) return 0;
    return start + SumNaturalDigits(start + 1, end);
}
Console.Write("Input M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Input N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write($"M = {M}; N = {N} -> {SumNaturalDigits(M, N)}");
*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
/*
int Ackerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return Ackerman(m - 1, 1);
    return Ackerman(m - 1, Ackerman(m, n - 1));
}
Console.Write("Input m: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Input n: ");
int N = Convert.ToInt32(Console.ReadLine());
int result = Ackerman(M,N);
Console.Write($"m = {M}; n = {N} -> A({M},{N}) = {result}");
*/
