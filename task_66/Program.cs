// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов 
// в промежутке от M до N.

int InputNum(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int Sum(int m, int n)
{
    if (m == n)
        return n;
    return n + Sum(m, n - 1);
}

int m = InputNum("Введите значение M:");
int n = InputNum("Введите значение N:");
Console.WriteLine($"Сумма элементов от {m} до {n} равна {Sum(m, n)}");