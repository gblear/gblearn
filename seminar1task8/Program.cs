// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число");

string num = Console.ReadLine();

int n = int.Parse(num);

int res = 1;

while (res <= n)
{
    res = res + 1 ;
    if(res % 2 == 0)
    {
        Console.Write(res + " ");
    }
}

 
