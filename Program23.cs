/*Задача 23: Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

void Kub (int[] number)
{
  int index = 0;
  int length = number.Length;
  while (index <  length)
  {
    number[index] = Convert.ToInt32(Math.Pow(index, 3));
    index = index+1; //index++
  }
}
void Print(int[] coll)
{
  int counter = coll.Length;
  int index1 = 0;
  while(index1 < counter)
  {
    Console.Write(coll[index1]+ " ");
    index1 = index1 + 1; //index1++
  }
} 
int[] Number1 = new int[number+1];
Kub(Number1);
Print(Number1);