// Задача 2. Даны 2 числа а и в. Если а больше, чем в - вывести соответствующую надпись, если нет - наоборот.  
Console.WriteLine("enter number a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter number b");
int b = Convert.ToInt32(Console.ReadLine());
if (a>b)
{
    Console.WriteLine("a больше, чем b");
}
else
{
    Console.WriteLine("b больше, чем a");
}
