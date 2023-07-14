// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int number1 = Math.Abs(number);
string num = number1.ToString();
char [] array = new char[num.Length]; 
for (int i = 0; i < num.Length; i++){
    array[i] = num[i];
}
if (array[0] == array[4] && array[1] == array[3]){
    Console.WriteLine($"Число {number} – это палиндром.");
}
else Console.WriteLine($"Число {number} не является палиндромом.");

