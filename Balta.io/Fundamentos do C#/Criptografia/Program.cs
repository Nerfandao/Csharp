namespace Criptografia
{
    public class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        public static List<usuario> listausuario = new List<usuario>();
        static void Menu()
        {
            int sair = 0;
            while (sair != 1)
            {
                Console.WriteLine("---- Bem Vindo aos serviços da KNUP ----");
                Console.WriteLine("Qual Operação você deseja executar?");
                Console.WriteLine("1 - Logar");
                Console.WriteLine("2 - Cadastrar");
                Console.WriteLine("3 - Recuperar Senha");
                Console.WriteLine("4 - Sair");

                short res = short.Parse(Console.ReadLine());

                switch (res)
                {
                    case 1:
                    case 2:
                        perguntar(res);
                        break;
                    case 3:
                        perguntaruser(res);
                        break;
                    case 4:
                        sair = 1;
                        Console.WriteLine("---- Obrigado por usar nossos serviços ----");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Operação não disponivel");
                        break;
                }
                Console.Clear();
            }
        }
        static void perguntar(short res)
        {
            Console.WriteLine("Digite o Usuário");
            string usuario = Console.ReadLine();
            Console.WriteLine("Digite a senha");
            string senha = Console.ReadLine();

            Console.Clear();

            switch (res)
            {
                case 1:
                    logar(usuario, senha);
                    break;
                case 2:
                    cadastrar(usuario, senha);
                    break;
            }
        }

        static void perguntaruser(short res)
        {
            Console.WriteLine("Digite o usuario: ");
            string usuario = Console.ReadLine();

            Console.Clear();
            switch (res)
            {
                case 3:
                    descriptografar(usuario);
                    break;
            }
        }

        static void logar(string usuario, string senha)
        {
            senha = criptografarSenha(senha);

            var usuarioexistente = listausuario.FirstOrDefault(x => x.login == usuario && x.senha == senha);
            if (usuarioexistente == null)
                Console.WriteLine("Usuário ou senha invalidos");
            else
                Console.WriteLine("Usuário logado com sucesso");

            Console.ReadKey();
        }

        static void cadastrar(string usuario, string senha)
        {

            senha = criptografarSenha(senha);

            var usuarioexistente = listausuario.FirstOrDefault(x => x.login == usuario);
            if (usuarioexistente == null)
                listausuario.Add(new Program.usuario { login = usuario, senha = senha });
            else
                listausuario.FirstOrDefault(x => x.login == usuario).senha = senha;

            Console.WriteLine("Usuário cadastrado com Sucesso");
            Console.ReadKey();
        }

        static string descriptografar(string usuario)
        {
            return "";
        }

        static string criptografarSenha(string senha)
        {
            return "";
        }

        public class usuario
        {
            public string login { get; set; }
            public string senha { get; set; }
        }
    }
}