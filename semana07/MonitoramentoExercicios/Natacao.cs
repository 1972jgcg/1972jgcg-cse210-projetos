using System;
using System.Collections.Generic;

class Natacao : Atividade
{
    private int voltas;

    public Natacao(DateTime data, int duracaoMinutos, int voltas)
        : base(data, duracaoMinutos)
    {
        this.voltas = voltas;
    }

    public override double ObterDistancia() => voltas * 50.0 / 1000.0; // metros -> km

    public override double ObterVelocidade() => (ObterDistancia() / DuracaoMinutos) * 60;

    public override double ObterRitmo() => DuracaoMinutos / ObterDistancia();
}