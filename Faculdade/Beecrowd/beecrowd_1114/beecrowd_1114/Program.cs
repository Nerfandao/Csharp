using System;

namespace beecrowd_1114
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var i = false;
            while (i == false)
            {
                int senha = int.Parse(Console.ReadLine());
                if (senha == 2002)
                {
                    Console.WriteLine("Acesso Permitido");
                    i = true;
                }
                else
                {
                    Console.WriteLine("Senha Invalida");
                }
            }
        }
    }
}