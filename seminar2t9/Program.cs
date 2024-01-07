System.Random numSintezator = new System.Random();

int rndnum = numSintezator.Next(10,100);

Console.WriteLine(rndnum);

int firstNum = rndnum/10;
int secondNum = rndnum%10;

if (firstNum == secondNum)
{
    Console.WriteLine("Nubm1 = Numb2");
}
else
{
    if(firstNum > secondNum)
    {
        Console.WriteLine("num1 > numb2");
    }
    else
    {
        Console.WriteLine("num2 > num1");
    }
}