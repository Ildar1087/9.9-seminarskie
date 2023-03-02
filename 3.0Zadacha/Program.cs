/***Задача 67:**Напишите программу, 
которая будет принимать на вход число и возвращать сумму его цифр.

453 -> 12

45 -> 9*/

Console.Clear();
Console.Write("введите число: ");
int n = int.Parse(Console.ReadLine());
int SummaChisla(int number)
{
  int sum = 0;
  while (n > 0)
  {
    int num = n % 10;
    n = n / 10;
    sum = sum + num;
  }
  return sum;
}
Console.WriteLine($"{SummaChisla(n)}");
