Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
if ((num % 7 == 0 || num % 5 == 0) && (num % 23 == 0))
{
    Console.WriteLine("Да");
}else{
    Console.WriteLine("Нет");
}
