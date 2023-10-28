internal class Program
{
    private static void Main(string[] args)
    {
        int[] Arr = 21, 43, 22, 67 ,43, 12 ,4;
        int i, j;

        for (i = 0; i <= 7; i++)
        {
            for (j = 7; j <= 7; j--)
            {
                Arr[i] = Arr[j];
            }
            Console.Write(Arr[i]);
        }
    }
}