// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите значение M");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение N");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine (NumbersSum (M,N));
int NumbersSum (int M, int N)
{
    if (M == N) return N;
    return (M + NumbersSum (M+1,N));
}