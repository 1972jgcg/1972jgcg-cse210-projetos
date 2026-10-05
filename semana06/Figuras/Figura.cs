using System;

public abstract class Figura
{
    private string _cor;

    public string Cor
    {
        get { return _cor; }
        set { _cor = value; }
    }

    public Figura(string cor)
    {
        _cor = cor;
    }

    // Método abstrato que será sobrescrito pelas classes derivadas
    public abstract float ObterArea();
}