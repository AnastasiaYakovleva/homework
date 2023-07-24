// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int GetSumEven(int [] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            sum ++;
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

int [] array = GenerateRandomArray(5, 99, 1001);
Console.Write($"B массиве [{String.Join(", ", array)}]");
Console.Write($" количество четных чисел равно {GetSumEven(array)}.");


