﻿Console.WriteLine("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Akkerman(M, N));

int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;

    else if (n == 0 && m > 0)
        return Akkerman(m - 1, 1);

    else
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
}

Console.ReadLine();