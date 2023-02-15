//Напишите программу, которая принимает на вход число и проверяет,
//кратно ли оно одновременно 7 и 23

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
// or int.Parse(Console.ReadLine());

if (a % 7 == 0)
{
  if (a % 23 == 0)

  {
    Console.WriteLine("да");
  }

}
else
{
  Console.WriteLine("нет");
}
