// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] array = {1, 6, 5, 7, 1, 1, 4, 3, 2};
Random rand = new Random();

double min = array[0];
double max = 0;
double res = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(1,10);
    if (array[i] > max)
{
    max = array[i];
}
if (array[i] < min)
{
    min = array[i];
}
}

res = max - min;

Console.WriteLine(string.Join(", ",array));
Console.WriteLine(res);
Console.WriteLine($"максимальное значение = {max}");
Console.WriteLine($"минимальное значение = {min}");
