Console.WriteLine("ENTER NUMBER");
string num = Console.ReadLine();

int NUMBER = int.Parse(num);

if(NUMBER % 7 == 0)
{
    if(NUMBER % 23 == 0)
    {
        Console.WriteLine("Ваше число кратно и 7 и 23");
    }
    else
    {
        Console.WriteLine("Ваше число кратно 7, но не кратно 23");
    }
}
else
{
    if(NUMBER % 23 == 0)
    {
        Console.WriteLine("Ваше число не кратно 7, но кратно 23");
    }
    else
    {
        Console.WriteLine("Ваше число не кратно ни 7, ни 23");
    }
}
