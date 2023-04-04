namespace beecrowd_1180
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int entrada = int.Parse(Console.ReadLine());
            int[] numeros = new int[entrada];

            string[] todosnumeros = Console.ReadLine().Split(' ');

            for (int i = 0; i < entrada; i++)
            {
                numeros[i] = int.Parse(todosnumeros[i]);
            }

            int menor = numeros[0];
            int posicao = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] < menor)
                {
                    menor = numeros[i];
                    posicao = i;
                }
            }
            Console.WriteLine("Menor valor: " + menor);
            Console.WriteLine("Posicao: " + posicao);
        }
    }
}