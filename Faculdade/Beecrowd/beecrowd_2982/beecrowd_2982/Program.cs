using System;

namespace beecrowd_2982
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int qtdvalores = int.Parse(Console.ReadLine());
            string[] valores;
            string tipo;
            int valor;
            int G = 0, V = 0;

            for (int i = 0; i < qtdvalores; i++)
            {
                valores = (Console.ReadLine().Split(' '));
                tipo = valores[0];
                valor = int.Parse(valores[1]);

                if (tipo == "G")
                    G = valor + G;

                else if (tipo == "V")
                    V = valor + V;
            }
            if (G > V)
                Console.WriteLine("NAO VAI TER CORTE, VAI TER LUTA!");
            
            else 
                Console.WriteLine("A greve vai parar.");
        }
    }
}