namespace manipulaçãoDeArquivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var caminho = "C:\\TrabalhandoComArquivos";
            var caminhoPathCombine = Path.Combine(caminho, "Pasta Teste 3", "SubPastaTeste3");
            FileHelper helper = new FileHelper();
            //helper.ListarDiretorios(caminho);
            //helper.ListarArquivosDiretorios(caminho);

            System.Console.WriteLine("Criando diretorio: " + caminhoPathCombine);
            helper.CriarDiretorio(caminhoPathCombine);
        }
    }
}