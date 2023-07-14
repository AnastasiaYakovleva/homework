// Напишите программу, которая принимает на вход 
// число (N) и выдаёт таблицу кубов чисел 
// от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void ShowCubes(int x){
    for (int i = 1; i <= x; i++){
    double cube = Math.Pow (i, 3);
    Console.Write($"{cube} ");
    } 
}

int GetNumber(string s){
    Console.Write(s);
    return Convert.ToInt32(Console.ReadLine());
}

int n = GetNumber("Введите число: ");
ShowCubes(n);