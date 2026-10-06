using System;

public class MetaSimples : Meta
{
    private bool _estaCompletada;

    public MetaSimples(string nome, int pontos) : base(nome, pontos)
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
        return _estaCompletada ? $"[X] {_nome}" : $"[ ] {_nome}";
    }
}
