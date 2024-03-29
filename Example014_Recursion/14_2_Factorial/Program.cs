﻿// нахождение факториала числа

int FactorialFor(int n) // итеративный подход.
{
  int result = 1;
  for (int i = 1; i <= n; i++) result *= i;
  return result;
}

int FactorialRec(int n) // рекурсивный подход.
{
  if (n == 1 || n == 0) return 1;
  else return n * FactorialRec(n - 1);
}

Console.WriteLine(FactorialFor(10)); // 3628800
Console.WriteLine(FactorialRec(10)); // 3628800