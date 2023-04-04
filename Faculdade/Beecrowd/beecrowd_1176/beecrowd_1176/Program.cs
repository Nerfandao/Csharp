namespace beecrowd_1176
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int casosTest = int.Parse(Console.ReadLine());
            int num = 0, soma = 0;
            int fibo;
            long[] completo = new long[61];
            completo[0] = 0;
            completo[1] = 1;

            for (int j = 2; j <= 60; j++)
            {
                completo[j] = completo[j - 1] + completo[j - 2];
            }

            for (int i = 0; i < casosTest; i++)
            {
                fibo = int.Parse(Console.ReadLine());
                Console.WriteLine($"Fib({fibo}) = {completo[fibo]}");
            }
        }
    }
}