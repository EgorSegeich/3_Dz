void PrintArray (int[] a, int l)
{
    for (int i=0; i<l; i++)
    {
        a[i] = i + 1;
        Console.WriteLine(a[i]*a[i]*a[i]);
    }
}

Console.WriteLine("введите число  ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];

PrintArray(array, N);