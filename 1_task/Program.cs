Console.WriteLine("введите 5-значное число  ");
int X = Convert.ToInt32(Console.ReadLine());

int X1 = X / 10000;
int X2 = (X - (X1*10000)) / 1000;
int X3 = (X - (X1*10000) - (X2*1000)) / 100;
int X4 = (X - (X1*10000) - (X2*1000) - (X3*100)) / 10;
int X5 = (X - (X1*10000) - (X2*1000) - (X3*100)) % 10;

int sum = X5*10000 + X4*1000 + X3*100 + X2*10 + X1%10;

if (X == sum)
{
Console.WriteLine("да");
}

else
{
Console.WriteLine("нет");
}