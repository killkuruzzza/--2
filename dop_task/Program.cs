// На столе лежат n монеток. Некоторые из них лежат вверх решкой, 
// а некоторые – гербом. Определите минимальное число монеток, которые нужно перевернуть, 
// чтобы все монетки были повернуты вверх одной и той же стороной.
Console.Clear();
Console.Write("Введите кол-во элементов: ");
int n = int.Parse(Console.ReadLine());
int[] array1 = new int[n];
Console.Write("Массив: ");


for (int i = 0; i < n; i++){
    array1[i] = new Random().Next(0, 2);
}
Console.WriteLine("for");
for (int i = 0; i < n; i++)
{
    Console.Write($"{array1[i]} ");
}
Console.WriteLine();
Console.WriteLine("while");
int j = 0;
while (j < n) {
    Console.Write($"{array1[j]} ");
    j++;
}


int r = 0, g = 0;
for (int i = 0; i < n; i++)
{
    if (array1[i] == 1){
        r++;
    }else{
        g++;
    }
}

Console.WriteLine();
if (r < g){
    Console.Write($"{r}");
}
else {
    Console.Write($"{g}");
}