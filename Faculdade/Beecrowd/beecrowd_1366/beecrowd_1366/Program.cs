namespace beecrowd_1366
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                while (true)
                {
                    int n = int.Parse(Console.ReadLine());
                    if (n == 0)
                    {
                        break;
                    }
                    int s = 0;
                    for (int i = 0; i < n; i++)
                    {
                        string[] input = Console.ReadLine().Split();
                        int b = int.Parse(input[1]);
                        s += b / 2;
                    }
                    Console.WriteLine(s / 2);
                }
            }
        }
    }
}