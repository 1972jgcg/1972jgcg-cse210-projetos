using System;

public class Retangulo : Figura
{
    private float _lado1;
    private float _lado2;

    public Retangulo(string cor, float lado1, float lado2) : base(cor)
    {
        _lado1 = lado1;
        _lado2 = lado2;
    }

    public override float ObterArea()
    {
        return _lado1 * _lado2;
    }
}