Console.WriteLine("введите число  ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];

for (int i=0; i<N; i++)
{
    array[i] = i + 1;
    Console.WriteLine(array[i]*array[i]*array[i]);
}


/*
//1
for (int i=1; i<=N; i++)
{
    Console.WriteLine(i*i*i);
}
*/
  


/*
//2
int i = 0;
int array[i] = 1;
while (i < N)
{
    array[i] = array[i] + 1;
    Console.WriteLine(sum);
    i++;     
}
*/