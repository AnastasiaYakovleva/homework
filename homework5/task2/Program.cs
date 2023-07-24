// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int GetSumUneven(int [] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
            sum += array[i];
    }
return sum;
}

int [] GenerateRandomArray(int elements, int start, int finish)
{
    int [] array = new int[elements];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(start, finish);
        }
return array;
}

int [] array = GenerateRandomArray(5, 1, 100);
Console.Write($"B массиве [{String.Join(", ", array)}]");
Console.Write($" сумма элементов, стоящих на нечетных позициях, равна {GetSumUneven(array)}.");
