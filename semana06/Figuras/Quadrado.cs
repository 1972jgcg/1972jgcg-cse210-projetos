using System;

public class Quadrado : Figura
{
    private float _lado;

    public Quadrado(string cor, float lado) : base(cor)
    {
        _lado = lado;
    }

    public override float ObterArea()
    {
        return _lado * _lado;
    }
}