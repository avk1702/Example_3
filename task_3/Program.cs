//Напишите программу, которая принимает на вход число и проверяет,
//кратно ли оно одновременно 7 и 23
// Решение с применением метода - метод назвали Check

bool Check(int value)
{
  return value % 7 == 0 && value % 23 == 0;
}

Console.Write("a = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Check(a));

// Не обязательно (для красоты)

if (Check(a))
{
  
  {
    Console.WriteLine("делится на 7 и 23");
  }

}
else
{
  Console.WriteLine("не делится на 7 и 23");
}
