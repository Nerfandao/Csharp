using System;
using System.Globalization;

namespace beecrowd_1064
{
    public class Program
    {
        static void Main(string[] args)
        {
            int j = 0;
            double soma = 0;
            
            for (int i = 0; i  < 6 ; i++)
            {
                double num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (num > 0 )
                {
                    j++;
                    soma = num + soma;
                }
            }
            soma = soma / j;
            Console.WriteLine($"{j} valores positivos");
            Console.WriteLine(soma.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}