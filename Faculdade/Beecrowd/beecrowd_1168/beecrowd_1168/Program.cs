using System;
using System.Collections.Generic;

namespace beecrowd_1168
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> respfinal = new List<string>();
            int entrada = int.Parse(Console.ReadLine());
            for (int i = 0; i < entrada; i++)
            {
                int led = 0;
                string letreiro = Console.ReadLine();
                foreach (char j in letreiro)
                {
                    if (j == '1')
                        led += 2;
                    if (j == '2' || j == '5' || j == '3')
                        led += 5;
                    if (j == '4')
                        led += 4;
                    if (j == '6' || j == '9' || j == '0')
                        led += 6;
                    if (j == '7')
                        led += 3;
                    if (j == '8')
                        led += 7;
                }
                respfinal.Add($"{led} leds");
            }
            foreach (string i in respfinal)
            {
                Console.WriteLine(i);
            }

        }
    }
}