using System;
using System.Threading;

abstract class Atividade
{
    private string _nome;
    private string _descricao;
    private int _duracao;

    public string Nome => _nome;
    public string Descricao => _descricao;
    public int Duracao => _duracao;

    protected Atividade(string nome, string descricao)
    {
        _nome = nome;
        _descricao = descricao;
    }

    public void ExibirMensagemInicial()
    {
        Console.WriteLine($"\nIniciando atividade: {_nome}");
        Console.WriteLine(_descricao);
        Console.Write("Digite a duração em segundos: ");
        _duracao = int.Parse(Console.ReadLine());

        Console.WriteLine("Prepare-se para começar...");
        ExibirProgresso(3);
    }

    public void ExibirMensagemFinal()
    {
        Console.WriteLine("\nBom trabalho!");
        Console.WriteLine($"Você concluiu a atividade {_nome} por {_duracao} segundos.");
        ExibirProgresso(3);
    }

    public void ExibirProgresso(int segundos)
    {
        DateTime fim = DateTime.Now.AddSeconds(segundos);
        while (DateTime.Now < fim)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public void ExibirContagemRegressiva(int segundos)
    {
        for (int i = segundos; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }

    public abstract void Executar();
}