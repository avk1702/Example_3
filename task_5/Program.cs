//Напишите программу, которая принимает на вход два числа и проверяет,
// является ли одно число квадратом другого. 5, 25 -> да -4, 16 -> да 25, 5 -> да 8,9 -> нет

// решение с применением метода
bool Square(int a, int b)
{
  return b == a * a;
}

Console.Write(" Введите первое число  ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write(" Введите второе число  ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Square(a,b));

// Не обязательно (для красоты)

if (Square(a,b))
{
    Console.WriteLine("Второе число является квадратом первого");  
}
else
{
    Console.WriteLine("Второе число не является квадратом первого"); 
}