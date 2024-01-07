System.Random numSintezator = new System.Random();

int rndnum = numSintezator.Next(100,1000);

Console.WriteLine(rndnum);

int LastD = rndnum%10;
int FirstD = rndnum/100;

int Nubm1 = FirstD * 10;
int Numb2 = LastD;

Console.WriteLine(Nubm1 + Numb2);



