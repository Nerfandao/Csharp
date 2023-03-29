namespace beecrowd_1397
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, pontos1 = 0, pontos2 = 0;
            int numTestes = int.Parse(Console.ReadLine());

            while (numTestes > 0)
            {

                for (int i = 0; i < numTestes; i++)
                {
                    string[] vals = Console.ReadLine().Split(' ');
                    A = int.Parse(vals[0]);
                    B = int.Parse(vals[1]);

                    if (A > B)
                    {
                        pontos1++;
                    }
                    else if (A < B)
                    {
                        pontos2++;
                    }
                    else if (A == B)
                    {
                        pontos1 += 0;
                        pontos2 += 0;
                    }

                }
                Console.WriteLine(pontos1 + " " + pontos2);
                pontos1 = 0;
                pontos2 = 0;
                numTestes = int.Parse(Console.ReadLine());
            }
        }
    }
}