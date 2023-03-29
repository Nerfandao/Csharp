using System;
using System.Collections.Generic;

namespace beecrowd_1129
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] leitura;
            int A = 0, B = 0, C = 0, D = 0, E = 0;
            int resp;
            List<string> respfinal = new List<string>();

            while ((resp = int.Parse(Console.ReadLine())) != 0)
            {
                for (int i = 0; i < resp; i++)
                {
                    List<string> respostaLinha = new List<string>();
                    leitura = Console.ReadLine().Split(' ');
                    A = int.Parse(leitura[0]);
                    B = int.Parse(leitura[1]);
                    C = int.Parse(leitura[2]);
                    D = int.Parse(leitura[3]);
                    E = int.Parse(leitura[4]);

                    if (A <= 127)
                        respostaLinha.Add("A");
                    if (B <= 127)
                        respostaLinha.Add("B");
                    if (C <= 127)
                        respostaLinha.Add("C");
                    if (D <= 127)
                        respostaLinha.Add("D");
                    if (E <= 127)
                        respostaLinha.Add("E");
                    if (respostaLinha.Count > 1)
                        respfinal.Add("*");
                    else
                        respfinal.Add(respostaLinha[0]);
                }
                
            }
            foreach (string i in respfinal)
            {
                Console.WriteLine(i);
            }
        }
    }
}