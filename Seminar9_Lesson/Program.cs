// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"
/*
void WriteArr(int[] arr)
{
    string strArr = String.Join(", ", arr);
    Console.Write($"{strArr}");
}
int[] CreateArr(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
        arr[i] = Convert.ToInt32(Console.ReadLine());

    return arr;
}
Console.Write("input the length of the array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = CreateArr(size);
Console.Write($"N = {size} -> ");
WriteArr(arr);
*/
// с помощью рекурсии
/*
string WriteArr(int num, string result)
{
    if (num == 1)
    {
        result = '1' + " " + result;
        return result;
    }
    else
    {
        result = num + " " + result;
        return WriteArr(num - 1, result);
    }
}
string result = "";
Console.Write("input the number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(WriteArr(num, result));
*/

// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"
/*
string PrintNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    return (start + " " + PrintNumbers(start + 1, end));
}

Console.WriteLine(PrintNumbers(1,8));
*/
/*
void WriteNaturalNumbers(int min, int max, int count = 0)
{

    if (min > count) count = min;
    else count++;
    Console.Write(count + " ");
    if (count < max) WriteNaturalNumbers(min, max, count);
}
Console.Write("Input a min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max: ");
int max = Convert.ToInt32(Console.ReadLine());
WriteNaturalNumbers(min,max);
*/

// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
/*
int SumDigits(int num)
{
    if (num == 0) return num;
    else return num % 10 + SumDigits(num / 10);
}
Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(SumDigits(num));
*/

// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8
/*
int PowerAB(int A, int B)
{
    if (B == 0) return 1;
    return A * PowerAB(A, B - 1);
}
Console.WriteLine(PowerAB(5, 3));
*/