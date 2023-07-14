// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int number1 = Math.Abs(number);
string num = number1.ToString();
char [] array = new char[num.Length]; 
for (int i = 0; i < num.Length; i++){
array[i] = num[i];}
if (array.Length > 2){
    Console.WriteLine($"Третья цифра {number} – это {num[2]}.");
}
else {
    Console.WriteLine($"У {number} нет третьей цифры.");
}
