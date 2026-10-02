using System;

class AtividadeDeListagem : Atividade
{
    private static readonly string[] _perguntas = {
        "Quem são as pessoas que você aprecia?",
        "Quais são seus pontos fortes pessoais?",
        "Quem são as pessoas que você ajudou esta semana?",
        "Quem são alguns dos seus heróis pessoais?"
    };

    public AtividadeDeListagem() 
        : base("Listagem", "Esta atividade ajudará você a refletir sobre as coisas boas da sua vida.") { }

    public override void Executar()
    {
        ExibirMensagemInicial();

        Random rand = new Random();
        Console.WriteLine(_perguntas[rand.Next(_perguntas.Length)]);
        Console.WriteLine("Liste o máximo de itens que puder. Pressione ENTER após cada item.");

        DateTime fim = DateTime.Now.AddSeconds(Duracao);
        int contador = 0;
        while (DateTime.Now < fim)
        {
            Console.ReadLine();
            contador++;
        }

        Console.WriteLine($"Você listou {contador} itens!");
        ExibirMensagemFinal();
    }
}
