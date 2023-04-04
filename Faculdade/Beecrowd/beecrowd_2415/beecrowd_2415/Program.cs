namespace beecrowd_2415
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numTestes = int.Parse(Console.ReadLine());
            int cont1 = 1, cont2 = 1;
            string[] valores;

            valores = Console.ReadLine().Split(' ');

            for (int i = 0; i < numTestes; i++)
            {

                if (i >= 1)
                {
                    if (valores[i] == valores[i - 1])
                    {
                        cont1++;
                    }
                    else if (valores[i - 1] != valores[i])
                    {
                        if (cont1 > cont2)
                        {
                            cont2 = cont1;
                        }
                        cont1 = 1;
                    }

                }
            }

            if (cont2 > cont1)
                Console.WriteLine(cont2);
            else
                Console.WriteLine(cont1);
        }
    }
}