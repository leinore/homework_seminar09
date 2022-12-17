// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int Function(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Function(m - 1, 1);
    else
        return Function(m - 1, Function(m, n - 1));
}

int m = InputInt("Введите положительное число M: ");
int n = InputInt("Введите положительное число N: ");
Console.WriteLine($"A({m}, {n}) = {Function(m, n)}");