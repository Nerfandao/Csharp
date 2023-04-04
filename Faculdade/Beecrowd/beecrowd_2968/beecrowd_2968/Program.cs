
namespace beecrowd_2968
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int voltas, placas;
            double media1;
            string[] entrada;

            entrada = Console.ReadLine().Split(' ');

            voltas = int.Parse(entrada[0]);
            placas = int.Parse(entrada[1]);

            media1 = (voltas * placas) / 10.0;
            double media = media1;

            Console.Write(Math.Ceiling(media));

            for (int i = 0; i < 8; i++)
            {
                media += media1;
                Console.Write(" ");
                Console.Write(Math.Ceiling(media));
            }
            Console.WriteLine();
        }
    }
}