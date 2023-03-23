using System;

namespace beecrowd_1049
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var resposta = Console.ReadLine();

            if (resposta == "vertebrado")
            {
                resposta = Console.ReadLine();
                if (resposta == "ave")
                {
                    resposta = Console.ReadLine();
                    if(resposta == "carnivoro")
                    {
                        Console.WriteLine("aguia");
                    }
                    else if(resposta == "onivoro")
                    {
                        Console.WriteLine("pomba");
                    }
                }
                else if(resposta == "mamifero")
                {
                    resposta = Console.ReadLine();
                    if (resposta == "onivoro")
                    {
                        Console.WriteLine("homem");
                    }
                    else if(resposta == "herbivoro")
                    {
                        Console.WriteLine("vaca");
                    }
                }
            }

            else if (resposta == "invertebrado")
            {
                resposta = Console.ReadLine();
                if (resposta == "inseto")
                {
                    resposta = Console.ReadLine();
                    if (resposta == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    }
                    else if (resposta == "herbivoro")
                    {
                        Console.WriteLine("lagarta");
                    }
                }
                else if (resposta == "anelideo")
                {
                    resposta = Console.ReadLine();
                    if (resposta == "hematofago")
                    {
                        Console.WriteLine("sanguessuga");
                    }
                    else if (resposta == "onivoro")
                    {
                        Console.WriteLine("minhoca");
                    }
                }
            }

        }
    }
}