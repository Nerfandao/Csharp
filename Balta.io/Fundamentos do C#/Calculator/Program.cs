using System;

namespace Caculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("----------------");
            Console.WriteLine("Selecione uma opção");

            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Sub(); break;
                case 3: Div(); break;
                case 4: Mult(); break;
                case 5: Sair(); break;
                default: Menu(); break;
            }

        }
        static void Soma()
        {
            Console.Clear();
            Console.Write("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 + v2;

            Console.WriteLine($"O resultado da soma é: {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void Sub()
        {
            Console.Clear();
            Console.Write("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 - v2;

            Console.WriteLine($"O resultado da subtração é: {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void Div()
        {
            Console.Clear();
            Console.Write("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 / v2;

            Console.WriteLine($"O resultado da divisão é: {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void Mult()
        {
            Console.Clear();
            Console.Write("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 * v2;

            Console.WriteLine($"O resultado da multplicação é: {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void Sair()
        {
            Console.Clear();
            Console.WriteLine("Você finalizou o programa :)");
        }
    }
}