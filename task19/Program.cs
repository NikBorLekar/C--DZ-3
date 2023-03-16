/*Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да
*/

Console.WriteLine("Введите число: ");
string? num = Console.ReadLine();

void Proverka(string num)
{
  if (num[0] == num[4] || num[1] == num[3])
  {
    Console.WriteLine($"Число {num} является палиндромом");
  }
  else Console.WriteLine($"Число {num} палиндром не является");
}
if (num!.Length == 5)
{
  Proverka(num);
}
else Console.WriteLine($"Введите пятизначное число");