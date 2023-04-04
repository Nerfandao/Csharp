namespace beecrowd_1047
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] entrada = Console.ReadLine().Split(' ');
            int horaIni = int.Parse(entrada[0]);
            int minutoIni = int.Parse(entrada[1]);
            int horaFim = int.Parse(entrada[2]);
            int minutoFim = int.Parse(entrada[3]);

            int duracao = (horaFim * 60 + minutoFim) - (horaIni * 60 + minutoIni);

            if (duracao <= 0)
            {
                duracao += 24 * 60;
            }

            int horas = duracao / 60;
            int minutos = duracao % 60;

            Console.WriteLine("O JOGO DUROU " + horas + " HORA(S) E " + minutos + " MINUTO(S)");
        }
    }
}