//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("введите число");
string Numb = Console.ReadLine();

int NUM = int.Parse(Numb);

if(NUM / 100 == 0)
{
    Console.WriteLine("У числа нет 3 разрядов");
}
else
{
    // if(NUM / 100 == 1)
    // {
    //     int numd1 = NUM % 10;
    //     Console.WriteLine(numd1);
    // }

    // if(NUM / 100 > 9 && NUM / 100 < 100)
    // {
    //     int numd1 = NUM % 100;
    //     int numd2 = numd1 / 10;
    //     Console.WriteLine(numd2);
    // }

    while(NUM>999)
    {
        NUM=NUM/10;
    }

    Console.WriteLine(NUM%10);
}