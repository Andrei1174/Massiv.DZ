#pragma warning disable

// Задача 2: Задайте массив на 10 целых чисел.
// Напишите программу, которая определяет
// количество чётных чисел в массиве.
// массив [6 7 19 34 3 1 4 7 9 1] => 3
// массив [1 8 43 4 55 60 3 2 1 3] => 4

// int[] array = new int[5];
// for (int i = 0; i < array.Length; i++)
// {
//      array[i] = new Random().Next(1,100);
//      Console.Write(array[i] + ","); 
// }
// int sum = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] % 2 == 0)
//         sum += array[i];
// }
// Console.WriteLine($" => {sum}");


int[] array = new int[10];
for (int i = 0; i < 10/*array.Length*/; i++)
{
     array[i] = new Random().Next(1,100);
     Console.Write(array[i] + ","); 
}
int kol = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
        kol = kol+1; 
}
Console.WriteLine($" =>  {kol}"); 
