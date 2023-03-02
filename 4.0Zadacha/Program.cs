// **Задача 69:**Напишите программу,
//  которая на вход принимает два числа A и B,
//   и возводит число А в целую степень B с помощью рекурсии.

// A = 3; B = 5-> 243(3⁵)

// A = 2; B = 3-> 8


Console.Clear();
Console.Write("введите число: ");
int n = int.Parse(Console.ReadLine());
Console.Write("введите степень: ");
int z = int.Parse(Console.ReadLine());
int Kvadrat(int chi)
{
  int sum = n;
  for (int i = 1; i < z; i++)
  {
    sum = sum*Kvadrat(n);
  }
  return sum;
}
Console.WriteLine($"{Kvadrat(n)}");