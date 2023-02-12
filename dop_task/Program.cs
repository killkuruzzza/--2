// На столе лежат n монеток. Некоторые из них лежат вверх решкой, 
// а некоторые – гербом. Определите минимальное число монеток, которые нужно перевернуть, 
// чтобы все монетки были повернуты вверх одной и той же стороной.
/*
int r = new Random().Next(1, 10);
int[] a = new int[r];
for (int i = 0; i < r;i++){
    a[i] = i;
}
for (int i = 0; i < r; i++){
    Console.Write($"{i} ");
}
*/
Console.Clear();
Console.Write("Введите кол-во элементов: ");
int n = int.Parse(Console.ReadLine());
int[] array1 = new int[n];
Console.Write("Массив: ");


int r = 0;
for (int i = 0; i < n; i++)
{
    array1[i] = new Random().Next(0, 2);
    Console.Write($"{array1[i]} ");
    if (array1[i] == 1){
        r++;
    }
}
Console.WriteLine();
if (r < n - r){
    Console.Write($"{r}");
}else{
    Console.Write($"{n - r}");
}

//Console.WriteLine("for");
// for (int i = 0; i < n; i++)
// {
//     
// }
// Console.WriteLine();
// Console.WriteLine("while");
// int j = 0;
// while (j < n) {
//     Console.Write($"{array1[j]} ");
//     j++;
// }
/*
if(a > b)
    b++;
else if(a < b)
    a++
else
    c++
*/


// int r = 0, g = 0;
// for (int i = 0; i < n; i++)
// {
    // if (array1[i] == 1){
    //     r++;
    // }else{
    //     g++;
    // }
// }

// Console.WriteLine();
// if (r < g){
//     Console.Write($"{r}");
// }
// else {
//     Console.Write($"{g}");
// }