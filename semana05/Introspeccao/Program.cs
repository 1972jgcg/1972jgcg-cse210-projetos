using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nMenu de Atividades:");
            Console.WriteLine("1 - Respiração");
            Console.WriteLine("2 - Reflexão");
            Console.WriteLine("3 - Listagem");
            Console.WriteLine("4 - Sair");
            Console.Write("Escolha uma opção: ");

            string escolha = Console.ReadLine();
            Atividade atividade = null;

            switch (escolha)
            {
                case "1": atividade = new AtividadeDeRespiracao(); break;
                case "2": atividade = new AtividadeDeReflexao(); break;
                case "3": atividade = new AtividadeDeListagem(); break;
                case "4": return;
                default: Console.WriteLine("Opção inválida."); continue;
            }

            atividade.Executar();
        }
    }
}