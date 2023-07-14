// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние 
// между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

void Space(int x1, int x2, int y1, int y2, int z1, int z2){
    double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    Console.Write($"Расстояние между двумя точками в пространстве равно {distance}.");
}

int GetNumber(string s){
    Console.Write(s);
    return Convert.ToInt32(Console.ReadLine());
}

int x1 = GetNumber("Введите координату X точки А: ");
int y1 = GetNumber("Введите координату Y точки А: ");
int z1 = GetNumber("Введите координату Z точки А: ");
int x2 = GetNumber("Введите координату X точки В: ");
int y2 = GetNumber("Введите координату Y точки В: ");
int z2 = GetNumber("Введите координату Z точки В: ");
Space(x1, x2, y1, y2, z1, z2);













// void Length(int x){
//     x = Math.Abs(x);
//     string num = x.ToString();
//     Console.Write(num.Length);
// }

// int GetNumber(string s){
//     Console.Write(s);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int digit = GetNumber("Введите число: ");
// Length(digit);


 