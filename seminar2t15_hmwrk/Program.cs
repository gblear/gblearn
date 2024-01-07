// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


Console.WriteLine("Введите число от 1 до 7 (день недели)");
string number = Console.ReadLine();

int num = int.Parse(number);

if(num > 7)
{
    Console.WriteLine("СУДАРЬ! ВЫ ВВЕЛИ не то ЧИСЛО! ВВЕДИТЕ от 1 ДО 7");
}
else
{
    string[] dateweek = new string[7];
    dateweek[0] = "Понедельник" ;
    dateweek[1] = "Вторник" ;
    dateweek[2] = "Среда" ;
    dateweek[3] = "Четверг" ;
    dateweek[4] = "Пятница" ;
    dateweek[5] = "Суббота" ;
    dateweek[6] = "Воскресение" ;

    Console.WriteLine(dateweek[num - 1]);
}