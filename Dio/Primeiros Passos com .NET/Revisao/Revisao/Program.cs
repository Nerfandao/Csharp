namespace Revisao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            var indiceAluno = 0;
            string opçcaoUsuario = ObterOpcaoUsuario();

            while (opçcaoUsuario.ToUpper() != "X")
            {
                switch (opçcaoUsuario)
                {
                    case "1":
                        Console.WriteLine("Informe o nome do aluno");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("Informe a nota");

                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.Nota = nota;
                        }
                        else
                        {
                            throw new ArgumentException("O Valor da nota deve ser decimal");
                        }

                        alunos[indiceAluno] = aluno;
                        indiceAluno++;

                        break;
                    case "2":
                        foreach(var a in alunos)
                        {
                            if (!string.IsNullOrEmpty(a.Nome))
                            {
                                Console.WriteLine($"ALUNO: {a.Nome} - NOTA: {a.Nota} ");
                            }
                        }

                        break;
                    case "3":
                        decimal notatotal = 0;
                        var nrAlunos = 0;

                        for (int i = 0 ; i < alunos.Length; i++)
                        {
                            if (!string.IsNullOrEmpty(alunos[i].Nome))
                            {
                                notatotal = notatotal + alunos[i].Nota;
                                nrAlunos++;
                            }
                        }

                        var mediaGeral = notatotal / nrAlunos;
                        Console.WriteLine($"MÉDIA GERAL: {mediaGeral}");

                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opçcaoUsuario = ObterOpcaoUsuario();
            }
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine("Informe a opção desejada");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Calcular média geral");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opçcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opçcaoUsuario;
        }
    }
}