// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите 2 числа");
string num1 = Console.ReadLine();
string num2 = Console.ReadLine();

int number1 = int.Parse(num1);
int number2 = int.Parse(num2);

if( number1 > number2 )
{
  Console.WriteLine("Первое число больше, чем второе");
}
else
{
    Console.WriteLine("Второе число больше, чем первое");
}