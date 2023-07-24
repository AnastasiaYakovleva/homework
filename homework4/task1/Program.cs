// Напишите цикл, который принимает на вход два числа (A и B) и 
//возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

void GetPower(int x, int y){
    Console.Write($"Число {x} в степени числа {y} – {Math.Pow(x, y)}.");
}

int GetNumber(string s){
    Console.Write(s);
    return Convert.ToInt32(Console.ReadLine());
}

int number1 = GetNumber("Введите первое число: ");
int number2 = GetNumber("Введите второе число: ");
GetPower(number1, number2);