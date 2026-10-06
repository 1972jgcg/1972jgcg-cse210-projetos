using System;
// Meta que pode ser concluída apenas uma vez.
// Demonstra encapsulamento ao controlar o estado interno (_estaCompletada).
public class MetaSimples : Meta
{
    private bool _estaCompletada;

    public MetaSimples(string nome, string descricao, int pontos) : base(nome, descricao, pontos)
    {
        _estaCompletada = false;
    }

    public override int RegistrarEvento()
    {
        if (!_estaCompletada)
        {
            _estaCompletada = true;
            return _pontos;
        }
        return 0;
    }

    public override string ObterDetalhesTexto()
    {
        return _estaCompletada
            ? $"[X] {_nome} ({_descricao})"
            : $"[ ] {_nome} ({_descricao})";
    }
}
