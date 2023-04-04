namespace beecrowd_2544
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double resultado;
            while (true)
            {
                int i = 0;
                string entrada = Console.ReadLine();
                if (string.IsNullOrEmpty(entrada))
                    break;

                double entrada1 = double.Parse(entrada);

                while (entrada1 % 2 == 0)
                {
                        i++;
                        entrada1 = entrada1 / 2;
                }
                Console.WriteLine(i);
            }
        }
    }
}