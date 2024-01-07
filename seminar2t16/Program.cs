Console.WriteLine("Введите 2 числа");
string Num1 = Console.ReadLine();
string Num2 = Console.ReadLine();

int N2 = int.Parse(Num1);
int N1 = int.Parse(Num2);

// if(N1 * N1 == N2 || N2 * N2 == N1)
// {
//     Console.WriteLine("Одно из чисел является квадратом другого");
// }
// else
// {
//     Console.WriteLine("Ни одно из чисел не является квадратом другого");
// }

void SqeaTest(int N1, int N2)
{
    if(N1 == N2 * N2)
    {
        Console.WriteLine("КРАТНО 2 1");
    }
    else
    {
        Console.WriteLine("НЕКРАТНО 2 1");
    }
}

SqeaTest (N1,N2);
SqeaTest (N2,N1);