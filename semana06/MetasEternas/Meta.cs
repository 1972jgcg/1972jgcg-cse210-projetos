using System;
// Classe base abstrata que define a estrutura comum para todas as metas.
// Aplica herança e polimorfismo: cada meta concreta implementa RegistrarEvento e ObterDetalhesTexto.
public abstract class Meta
{
    protected string _nome;
    protected int _pontos;
    protected string _descricao;

    public Meta(string nome, string descricao, int pontos)
    {
        _nome = nome;
        _descricao = descricao;
        _pontos = pontos;
    }

    public abstract int RegistrarEvento();
    public abstract string ObterDetalhesTexto();
}

