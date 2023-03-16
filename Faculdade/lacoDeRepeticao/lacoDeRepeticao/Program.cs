namespace lacoDeRepeticao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero para saber se ele é primo");
            //int num = int.Parse(Console.ReadLine());

            for (int num = 0; num < 500; num++)
            {
                if (num == 2 || num == 3 || num == 5 || num == 7)
                {
                    Console.WriteLine($"{num} É primo");
                }
                else if (num % 2 == 0 || num % 3 == 0 || num % 5 == 0 || num % 7 == 0)
                {
                    //Console.WriteLine($"{num} Não é primo");
                }
                else
                {
                    Console.WriteLine($"{num} É primo");
                }
            }
            Console.ReadKey();
        }
    }
}