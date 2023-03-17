/*Задача 21: Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

int x1 = FindOtrezok("x", "A");
int y1 = FindOtrezok("y", "A");
int z1 = FindOtrezok("z", "A");
int x2 = FindOtrezok("x", "B");
int y2 = FindOtrezok("y", "B");
int z2 = FindOtrezok("z", "B");

int FindOtrezok(string NameKoord, string NameTochka)
{
    Console.Write($"Введите координату {NameKoord} точки {NameTochka}: ");
    return Convert.ToInt32(Console.ReadLine());
}
double Metod (double x1, double x2, double y1, double y2, double z1, double z2)
{
  return Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2));
}
double DlinaOtrezka =  Math.Round (Metod(x1, x2, y1, y2, z1, z2), 2 );

Console.WriteLine($"Длина отрезка {DlinaOtrezka}");