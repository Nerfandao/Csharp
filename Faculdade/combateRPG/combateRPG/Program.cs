namespace combateRPG
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Barbaro cleber = new Barbaro();
            cleber.nome = "Cleber";
            cleber.nivel = 1;
            cleber.força = 10;
            cleber.vitalidade = 15;
            cleber.furia = 2;
            cleber.vida = 30;
            cleber.vidamax = 30;

            Barbaro jorge = new Barbaro();
            jorge.nome = "Jorge";
            jorge.nivel = 1;
            jorge.força = 10;
            jorge.vitalidade = 15;
            jorge.furia = 2;
            jorge.vida = 30;
            jorge.vidamax = 30;

            cleber.imprimirStatus();
            jorge.imprimirStatus();
            cleber.levelUP();
            cleber.imprimirStatus();
            cleber.atacar(jorge);
            jorge.imprimirStatus();
            jorge.curar();
            jorge.imprimirStatus();
        }
    }
}