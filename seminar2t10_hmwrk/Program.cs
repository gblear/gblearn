// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите 3-хзначное число");

string Numb = Console.ReadLine();

int Num = int.Parse(Numb);

if(Num > 99 && Num < 1000)
{
    int nmb = Num / 10;
    int NumDig = nmb % 10;
    Console.WriteLine(NumDig);
}
else
{
    Console.WriteLine("Введите ТРЕХЗНАЧНОЕ число");
}