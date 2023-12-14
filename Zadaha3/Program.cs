#pragma warning disable

// Задача 3: Задайте массив из вещественных чисел 
// с ненулевой дробной частью. Найдите разницу между 
// максимальным и минимальным элементов массива.
// массив [2.2 0.4 9.11 7.2 78.98] => 78.58
// массив [1.22 4.5 3.33] => 3.28

Console.Write("Задайте массив n: ");
int n = Convert.ToInt32(Console.ReadLine());

double[] array = new double[n];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().NextDouble()+ new Random().Next(0,100);  
    Console.Write($" {array[i] :F2}");
}
 double min = array[0];
 double max = array[0];
for (int i = 0; i < n; i++)
{
    if (max < array[i]) 
    max = array[i];    
    if (min > array[i]) 
    min = array[i];   
}
Console.WriteLine($" => {max - min :F2}");