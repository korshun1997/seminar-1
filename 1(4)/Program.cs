// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("enter number a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter number b");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter number c");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (a<b)
{
    max = b;
}
if (c> max)
{
    max = c;
}
Console.WriteLine($"Максимум из чисел равен {max}");