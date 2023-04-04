namespace beecrowd_1238
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] entrada = Console.ReadLine().Split(' ');
                string a = entrada[0], b = entrada[1];
                string resultado = "";
                int tamanho = Math.Max(a.Length, b.Length);

                for (int j = 0; j < tamanho; j++)
                {
                    if (j < a.Length)
                    {
                        resultado += a[j];
                    }
                    if (j < b.Length)
                    {
                        resultado += b[j];
                    }
                }

                Console.WriteLine(resultado);
            }
        }
    }
}