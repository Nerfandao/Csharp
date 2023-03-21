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
             * 1 - Abstração: Abstrair um objeto real, para um contexto específico, considerando apenas atributos importante
             * 2 - Encapsulamento: Serve pra proteger uma classe e definir limites para alteração de suas propriedades
             * 3 - Herença: Permite reutilizar atributos, métodos, e comportamentos de uma classe em outras classes
             * 3,4 - Polimorfismo: Sobescrever métodos das classes filhas para que se comportem de maneira diferente e ter sua própria implementação
             * 5 - Classe Abstrata: Exclusivamente um modelo para ser herdado, portante não pode ser instanciada
             * Classe Selada: Não pode ser herdada, ou seja não pode ter classes filhas. Também tem métodos e propriedades seladas
             * Classe System.Object: É a mãe de todos as classes na hierarquia, todas as classes derivam da classe object
             * Interface: É um contrato que pode ser implementado por uma classe, podendo definer metodos abstratos, uma interface não pode ser instanciada
             */

            // 1 - Abstração

            //Pessoa p1 = new Pessoa();
            //p1.Nome = "Bob";
            //p1.Idade = 20;
            //p1.Apresentar(); 

            // 2 - Encapsulamento

            //Retangulo r1 = new Retangulo();
            //r1.DefinirMedidas(30, 30);
            //System.Console.WriteLine($"Área: {r1.ObterArea()}");
            //Retangulo r2 = new Retangulo();
            //r2.DefinirMedidas(0, 30);
            //System.Console.WriteLine($"Área: {r2.ObterArea()}");

            // 3 - Herança e Polimorfismo em tempo de execução

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

            // 4 - Polimorfismo em tempo de compilação
            //Calculadora calc = new Calculadora();
            //Console.WriteLine("Resultado da primeira soma: " + calc.Somar(5,8));
            //Console.WriteLine("Resultado da segunda soma: " + calc.Somar(5, 8, 9));

            // 5 - Classe Abstrata
            //Corrente c = new Corrente();
            //c.Creditar(100);
            //c.Creditar(204);
            //c.ExibirSaldo();

            //Computador comp = new Computador();
            //Console.WriteLine(comp.ToString());

            //ICalculadora calc = new Calculadora();
            //int num1 = int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());
            //calc.Dividir(num1, num2);
        }
    }
}