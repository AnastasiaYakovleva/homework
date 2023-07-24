// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void PrintArray(int [] array){
    Console.WriteLine("[{0}]", string.Join(", ", array));
}

void FillArray(int [] array){
    int index = 0;
    int length = array.Length;
    for (index = 0; index < length; index++){
        array[index] = new Random().Next(1, 1000);
    }
}

int [] array = new int[8];
FillArray(array);
PrintArray(array);
