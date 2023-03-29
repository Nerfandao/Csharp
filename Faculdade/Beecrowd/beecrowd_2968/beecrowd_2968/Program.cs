namespace beecrowd_2968
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float voltas, placas, media1;
            string[] entrada;

            entrada = Console.ReadLine().Split(' ');

            voltas = float.Parse(entrada[0]);
            placas = float.Parse(entrada[1]);

            media1 = voltas * placas / 10;
            float media = media1;

            Console.Write(Math.Ceiling(media));

            for (int i = 0; i < 8; i++)
            {
                media += media1;
                Console.Write(" ");
                Console.Write(Math.Ceiling(media));
            }
        }
    }
}