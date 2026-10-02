using System;

class AtividadeDeRespiracao : Atividade
{
    public AtividadeDeRespiracao() 
        : base("Respiração", "Esta atividade ajudará você a relaxar, inspirando e expirando lentamente.") { }

    public override void Executar()
    {
        ExibirMensagemInicial();

        DateTime fim = DateTime.Now.AddSeconds(Duracao);
        while (DateTime.Now < fim)
        {
            Console.WriteLine("Inspire...");
            ExibirContagemRegressiva(3);
            Console.WriteLine("Expire...");
            ExibirContagemRegressiva(3);
        }

        ExibirMensagemFinal();
    }
}
