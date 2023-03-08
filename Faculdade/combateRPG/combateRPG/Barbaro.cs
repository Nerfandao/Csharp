namespace combateRPG
{
    public class Barbaro
    {
        public string nome;
        public int nivel;
        public int força;
        public int vitalidade;
        public int furia;
        public int vida;
        public int vidamax;


        public void imprimirStatus()
        {
            Console.WriteLine("Seu nome é: " + nome);
            Console.WriteLine("Seu nivel é: " + nivel);
            Console.WriteLine("Sua força é: " + força);
            Console.WriteLine("Sua vitalidade é: " + vitalidade);
            Console.WriteLine("Sua furia é: " + furia);
            Console.WriteLine("Sua vida atual é: " + vida);
            Console.WriteLine("");
        }

        public void levelUP()
        {
            nivel += 1;
            força += 10;
            vitalidade += 15;
            furia += 2;
            vida += 30;
            vidamax += 30;

            Console.WriteLine("["+nome+"] subiu de nivel!");
            Console.WriteLine("");
        }

        public void atacar(Barbaro Defensor)
        {
            Defensor.vida -= força;
            Console.WriteLine("["+nome+"] atacou ["+Defensor.nome+"] causando ["+força+"] de dano");
            Console.WriteLine("");
        }

        public void curar()
        {
            vida = vidamax;
            Console.WriteLine("[" + nome + "] tomou um poção de vida e se curou totalmente!");
            Console.WriteLine("");
        }
    }
}
