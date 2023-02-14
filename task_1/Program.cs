//Напишите программу, которая выводит случайное число из отрезка [10, 99] 
//и показывает наибольшую цифру числа. Например: 78 -> 8 12-> 2 85 -> 8
Random rnd = new Random();
int value = rnd.Next(10,99);
Console.WriteLine(value);
int a = value / 10;
int b = value % 10;
if (a > b)
{
  Console.WriteLine(a);
}
else
{
  Console.WriteLine(b);
}