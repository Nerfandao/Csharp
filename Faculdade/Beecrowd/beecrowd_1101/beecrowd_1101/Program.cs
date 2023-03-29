namespace beecrowd_1101
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool botao = true;

            while (botao = true)
            {

                int total1 = 0, total2 = 0;
                string[] val = Console.ReadLine().Split(' ');
                int A = int.Parse(val[0]);
                int B = int.Parse(val[1]);

                if (A <= 0 || B <= 0)
                {
                    botao = false;
                    break;
                }

                if (A > B)
                {
                    for (int i = B; i <= A; i++)
                    {
                        Console.Write(i + " ");
                        total1 += i;
                    }
                    Console.WriteLine("Sum=" + total1);
                    total1 = 0;
                }

                else if (B > A)
                {
                    for (int j = A; j <= B; j++)
                    {
                        Console.Write(j + " ");
                        total2 += j;
                    }
                    Console.WriteLine("Sum=" + total2);
                    total2 = 0;
                }
            }

        }
    }
}