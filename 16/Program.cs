Console.Clear();
Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine());
if (a * a == b)
{
    Console.WriteLine("b квадрат a");
    return;
}
if (Math.Pow(b, 2) == a)
{
    Console.WriteLine("a квадрат b");
}
else
{
    Console.WriteLine("не является");
}
