using System;

public class MetaEterna : Meta
{
    public MetaEterna(string nome, int pontos) : base(nome, pontos) { }

    public override int RegistrarEvento()
    {
        return _pontos; // nunca se completa, sempre dá pontos
    }

    public override string ObterDetalhesTexto()
    {
        return $"[∞] {_nome}";
    }
}
