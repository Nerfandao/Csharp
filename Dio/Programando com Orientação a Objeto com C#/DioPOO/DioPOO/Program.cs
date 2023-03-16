namespace DioPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Anotações:
             * Paradigma de programação: Conjunto de regras de uma linguagem
             * Classe: Onde é definido seus atributos e seus metodos(Ação). Basicamente um molde
             * Objeto: É a concretização da classe, onde é usado os atributos e metodos
             * Abstração: Abstrair um objeto real, para um contexto específico, considerando apenas atributos importante
             * Encapsulamento: Serve pra proteger uma classe e definir limites para alteração de suas propriedades
             */
            
            /* Pessoa p1 = new Pessoa();

            p1.Nome = "Bob";
            p1.Idade = 20;

            p1.Apresentar(); */

            Retangulo r1 = new Retangulo();
            r1.DefinirMedidas(30, 30);
            System.Console.WriteLine($"Área: {r1.ObterArea()}");

            Retangulo r2 = new Retangulo();
            r2.DefinirMedidas(0, 30);
            System.Console.WriteLine($"Área: {r2.ObterArea()}");

        }
    }
}