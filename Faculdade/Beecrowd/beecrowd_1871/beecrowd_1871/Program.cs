namespace beecrowd_1871
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] entrada;
            int num1 = 1, num2 = 1, soma;

            while (true) 
            { 
                entrada = Console.ReadLine().Split(' ');

                num1 = int.Parse(entrada[0]);
                num2 = int.Parse(entrada[1]);

                if (num1 == 0 && num2 == 0)
                    break;

                soma = num1 + num2;

                string resultado = soma.ToString();

                foreach (char i in resultado)
                {
                    if (i != '0')
                    Console.Write(i);
                }
                Console.Write("\n");
            }
        }
    }
}