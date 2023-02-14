//Напишите программу, которая будет принимать на вход два числа и выводить, 
//является ли второе число кратным первому. Если число 2 не кратно числу 1, 
//то программа выводит остаток от деления.
Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
// or int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a % b == 0)
{
  Console.WriteLine(b + " кратно " + a);
}
else
{
  int c = a % b;
  Console.WriteLine(b + " не кратно " + a);
  Console.WriteLine("остаток  " + c);
}
