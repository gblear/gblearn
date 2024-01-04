// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите 2 числа");
string num1 = Console.ReadLine();
string num2 = Console.ReadLine();
string num3 = Console.ReadLine();

int number1 = int.Parse(num1);
int number2 = int.Parse(num2);
int number3 = int.Parse(num3);

if(number1 > number2)
{
    if(number1 > number3)
    {
        Console.WriteLine("1 число самое большое");
    }
    else
    {
        Console.WriteLine("3 число самое большое");
    }
}
else
{
    if(number2 > number3)
    {
        Console.WriteLine("2 число самое большое");
    }
    else
    {
        Console.WriteLine("3 число самое большое");
    }
}