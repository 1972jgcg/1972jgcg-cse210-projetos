using System;

public class Circulo : Figura
{
    private float _raio;

    public Circulo(string cor, float raio) : base(cor)
    {
        _raio = raio;
    }

    public override float ObterArea()
    {
        return (float)(Math.PI * _raio * _raio);
    }
}