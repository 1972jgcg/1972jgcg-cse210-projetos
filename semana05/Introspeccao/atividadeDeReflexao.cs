using System;

class AtividadeDeReflexao : Atividade
{
    private static readonly string[] _reflexoes = {
        "Pense em uma ocasião em que você defendeu outra pessoa.",
        "Pense em uma ocasião em que você fez algo realmente difícil.",
        "Pense em uma ocasião em que você ajudou alguém necessitado.",
        "Pense em uma ocasião em que você fez algo altruísta."
    };

    private static readonly string[] _perguntas = {
        "Por que essa experiência foi significativa para você?",
        "Você já fez algo assim antes?",
        "Como você começou?",
        "Como você se sentiu quando terminou?",
        "O que você aprendeu sobre si mesmo?"
    };

    public AtividadeDeReflexao() 
        : base("Reflexão", "Esta atividade ajudará você a refletir sobre momentos de força e resiliência.") { }

    public override void Executar()
    {
        ExibirMensagemInicial();

        Random rand = new Random();
        string reflexao = _reflexoes[rand.Next(_reflexoes.Length)];
        Console.WriteLine(reflexao);

        // Pausa para reflexão até o usuário pressionar ENTER
        Console.WriteLine("\nPressione ENTER quando estiver pronto para continuar...");
        Console.ReadLine();

        DateTime fim = DateTime.Now.AddSeconds(Duracao);
        while (DateTime.Now < fim)
        {
            Console.WriteLine(_perguntas[rand.Next(_perguntas.Length)]);
            ExibirProgresso(5);
        }

        ExibirMensagemFinal();
    }
}
