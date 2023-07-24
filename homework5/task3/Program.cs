// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double [] GenerateRandomArray(int elements)
{
    double [] array = new double[elements];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(new Random().Next(-100, 100) + new Random().NextDouble(), 2);
        }
return array;
}

double FindMax (double [] array)
{
    double extreme = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > extreme) extreme = array[i];
    }
return extreme;
}

double FindMin (double [] array)
{
    double extreme = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < extreme) extreme = array[i];
    }
return extreme;
}

double [] array = GenerateRandomArray(5);
Console.Write($"B массиве [{String.Join(", ", array)}]");
Console.Write($" разница между минимумом {FindMin(array)} и максимумом {FindMax(array)} равна {Math.Round(FindMax(array) - FindMin(array), 2)}.");