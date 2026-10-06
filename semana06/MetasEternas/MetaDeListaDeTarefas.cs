using System;
// Meta composta por várias tarefas, com bônus ao completar todas.
// Demonstra encapsulamento e lógica adicional de progresso.
public class MetaDeListaDeTarefas : Meta
{
    private int _vezesNecessarias;
    private int _vezesConcluidas;
    private int _bonus;

    public MetaDeListaDeTarefas(string nome, string descricao, int pontos, int vezesNecessarias, int bonus)
        : base(nome, descricao, pontos)
    {
        _vezesNecessarias = vezesNecessarias;
        _vezesConcluidas = 0;
        _bonus = bonus;
    }

    public override int RegistrarEvento()
    {
        _vezesConcluidas++;
        if (_vezesConcluidas == _vezesNecessarias)
        {
            return _pontos + _bonus;
        }
        return _pontos;
    }

    public override string ObterDetalhesTexto()
    {
        return $"[ ] {_nome} ({_descricao}) -- Concluídas até agora: {_vezesConcluidas}/{_vezesNecessarias}";
    }
}

