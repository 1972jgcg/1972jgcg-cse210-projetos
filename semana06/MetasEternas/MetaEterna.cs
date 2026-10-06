using System;
// Meta que nunca se conclui, sempre pode registrar eventos.
// Mostra polimorfismo: comportamento diferente de MetaSimples.
public class MetaEterna : Meta
{
    public MetaEterna(string nome, string descricao, int pontos) : base(nome, descricao, pontos) { }

    public override int RegistrarEvento()
    {
        return _pontos;
    }

    public override string ObterDetalhesTexto()
    {
        return $"[ ] {_nome} ({_descricao})";
    }
}

