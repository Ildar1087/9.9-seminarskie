/*  Задача 68: Напишите программу вычисления функции Аккермана 
с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29  */

using System;
using static System.Console;
Console.Clear();
Console.Write("введите первое положительное число: ");
int n1 = int.Parse(Console.ReadLine());
Console.Write("введите второе положительное число: ");
int n2 = int.Parse(Console.ReadLine());
WriteLine($"Функция Аккермана = {FunctionAkkermana(n1, n2)}");
int FunctionAkkermana(int m, int n)
{
  if(m == 0) return n + 1;
  if(n == 0)  return FunctionAkkermana(m - 1, 1);
return FunctionAkkermana(m - 1, FunctionAkkermana(m, n - 1));
}


/*Функция Аккермана
0 n = n+1
ack n 0 = ack (n-1) 1
ack n m = ack (n-1) (ack n (m-1))*/