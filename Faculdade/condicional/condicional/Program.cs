namespace condicional
{
    internal class Program
    {
        public static void parOuImpar(int num1)
        {
            //TODO: Arrumar essa penga aqui
            if (num1 % 2 == 1)
                Console.WriteLine("Acesso concedido");
            else (num1 % 2 == 0)
                Console.WriteLine("Comando errado");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua senha");
            string pwd = Console.ReadLine();
            if (pwd == "patinho22") 
            {
                Console.Clear();
                Console.WriteLine("Logado com sucesso");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Digite um numero impar");
                int num1 = int.Parse(Console.ReadLine());
                parOuImpar(num1);
                if (num1 == 1)
                {
                    Console.WriteLine("Digite um numero de 0-6");
                    int dia = int.Parse(Console.ReadLine());
                    switch (dia)
                    {
                        case 0:
                            Console.WriteLine("Domingo");
                            break;
                        case 1:
                            Console.WriteLine("Segunda");
                            break;
                        case 2:
                            Console.WriteLine("Terça");
                            break;
                        case 3:
                            Console.WriteLine("Quarta");
                            break;
                        case 4:
                            Console.WriteLine("Quinta");
                            break;
                        case 5:
                            Console.WriteLine("Sexta");
                            break;
                        case 6:
                            Console.WriteLine("Sabado");
                            break;
                        default:
                            Console.WriteLine("Não existe esse comando");
                            break;
                    }
                }
                else
                    Console.WriteLine("Comando errado");
                           
            }
            else
                Console.WriteLine("Senha incorreta");
        }
    }
}