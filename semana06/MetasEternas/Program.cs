using System;
using System.Collections.Generic;

class Program
{
    // Lista de metas criadas pelo usuário.
    // Demonstra uso de coleções genéricas para armazenar objetos polimórficos.
    static List<Meta> metas = new List<Meta>();
    static int pontuacao = 0;

    static void Main(string[] args)
    {
        bool sair = false;

        while (!sair)
        {
            // Feedback imediato ao usuário: mostra pontuação atual.
            Console.WriteLine($"\nVocê tem {pontuacao} pontos.\n");

            // Menu principal do programa.
            // Cumpre requisito de interação simples via console.
            Console.WriteLine("--- Programa de Metas Eternas ---");
            Console.WriteLine("1. Criar Nova Meta");
            Console.WriteLine("2. Listar Metas");
            Console.WriteLine("3. Registrar Evento");
            Console.WriteLine("4. Sair");
            Console.Write("Selecione uma opção do menu: ");
            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    // Submenu de tipos de metas.
                    Console.WriteLine("Os tipos de metas são:");
                    Console.WriteLine("1. Meta Simples");
                    Console.WriteLine("2. Meta Eterna");
                    Console.WriteLine("3. Meta de Lista de Tarefas");
                    Console.Write("Qual tipo de meta você gostaria de criar? ");
                    string tipo = Console.ReadLine();

                    if (tipo == "1") CriarMetaSimples();
                    else if (tipo == "2") CriarMetaEterna();
                    else if (tipo == "3") CriarMetaDeLista();
                    break;

                case "2":
                    MostrarMetas();
                    break;

                case "3":
                    RegistrarEvento();
                    break;

                case "4":
                    sair = true;
                    break;
            }
        }
    }

    // Métodos de criação de metas.
    // Cada um pede nome, descrição e pontos, garantindo clareza e completude.
    private static void CriarMetaSimples()
    {
        Console.Write("Qual é o nome da sua meta? ");
        string nome = Console.ReadLine();

        Console.Write("Qual é uma descrição abreviada da sua meta? ");
        string descricao = Console.ReadLine();

        Console.Write("Qual é a quantidade de pontos associada a esta meta? ");
        int pontos = int.Parse(Console.ReadLine());

        metas.Add(new MetaSimples(nome, descricao, pontos));
        Console.WriteLine("Meta Simples criada com sucesso!");
    }

    private static void CriarMetaEterna()
    {
        Console.Write("Qual é o nome da sua meta? ");
        string nome = Console.ReadLine();

        Console.Write("Qual é uma descrição abreviada da sua meta? ");
        string descricao = Console.ReadLine();

        Console.Write("Qual é a quantidade de pontos por evento? ");
        int pontos = int.Parse(Console.ReadLine());

        metas.Add(new MetaEterna(nome, descricao, pontos));
        Console.WriteLine("Meta Eterna criada com sucesso!");
    }

    private static void CriarMetaDeLista()
    {
        Console.Write("Qual é o nome da sua meta? ");
        string nome = Console.ReadLine();

        Console.Write("Qual é uma descrição abreviada da sua meta? ");
        string descricao = Console.ReadLine();

        Console.Write("Qual é a quantidade de pontos por evento? ");
        int pontos = int.Parse(Console.ReadLine());

        Console.Write("Número de vezes necessárias: ");
        int vezes = int.Parse(Console.ReadLine());

        Console.Write("Bônus ao completar: ");
        int bonus = int.Parse(Console.ReadLine());

        metas.Add(new MetaDeListaDeTarefas(nome, descricao, pontos, vezes, bonus));
        Console.WriteLine("Meta de Lista de Tarefas criada com sucesso!");
    }

    // Exibe todas as metas criadas, chamando polimorficamente ObterDetalhesTexto().
    private static void MostrarMetas()
    {
        Console.WriteLine("As metas são:");
        for (int i = 0; i < metas.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {metas[i].ObterDetalhesTexto()}");
        }
    }

    // Registra evento em uma meta escolhida e soma pontos.
    // Demonstra gamificação: progresso e recompensa imediata.
    private static void RegistrarEvento()
    {
        MostrarMetas();
        Console.Write("Selecione o número da meta para registrar evento: ");
        int indice = int.Parse(Console.ReadLine()) - 1;

        if (indice >= 0 && indice < metas.Count)
        {
            pontuacao += metas[indice].RegistrarEvento();
            Console.WriteLine("Evento registrado!");
        }
    }
}


