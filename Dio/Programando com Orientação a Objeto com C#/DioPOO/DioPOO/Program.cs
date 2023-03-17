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
             * Herença: Permite reutilizar atributos, métodos, e comportamentos de uma classe em outras classes
             * Polimorfismo: Sobescrever métodos das classes filhas para que se comportem de maneira diferente e ter sua própria implementação
             */
            
            //Pessoa p1 = new Pessoa();

            //p1.Nome = "Bob";
            //p1.Idade = 20;

            //p1.Apresentar(); 

            //Retangulo r1 = new Retangulo();
            //r1.DefinirMedidas(30, 30);
            //System.Console.WriteLine($"Área: {r1.ObterArea()}");

            //Retangulo r2 = new Retangulo();
            //r2.DefinirMedidas(0, 30);
            //System.Console.WriteLine($"Área: {r2.ObterArea()}");

            //Aluno p2 = new Aluno();
            //p2.Nome = "Fernando";
            //p2.Idade = 20;
            //p2.Nota = 9;
            //p2.Documento = "67494";

            //p2.Apresentar();

            //Professor p3 = new Professor();
            //p3.Nome = "Eduardo";
            //p3.Idade = 34;
            //p3.Salario = 5000;
            //p3.Documento = "28473";

            //p3.Apresentar();

            Calculadora calc = new Calculadora();
            Console.WriteLine("Resultado da primeira soma: " + calc.Somar(5,8));
            Console.WriteLine("Resultado da segunda soma: " + calc.Somar(5, 8, 9));

        }
    }
}