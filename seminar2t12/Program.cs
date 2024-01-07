System.Random numSintezator = new System.Random();

int rndnum1 = numSintezator.Next(100,1000);
int rndnum2 = numSintezator.Next(100,1000);

Console.WriteLine(rndnum1 + " " + rndnum2);


if(rndnum1 % rndnum2 == 0)
{
    Console.WriteLine(" 2 ЧИСЛО КРАТНО 1");
}
else
{
    Console.WriteLine("2 ЧИСЛО НЕ КРАТНО ПЕРВОМУ");
}