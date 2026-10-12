using System;
using System.Collections.Generic;
class Corrida : Atividade
{
    private double distanciaKm;

    public Corrida(DateTime data, int duracaoMinutos, double distanciaKm)
        : base(data, duracaoMinutos)
    {
        this.distanciaKm = distanciaKm;
    }

    public override double ObterDistancia() => distanciaKm;

    public override double ObterVelocidade() => (distanciaKm / DuracaoMinutos) * 60;

    public override double ObterRitmo() => DuracaoMinutos / distanciaKm;
}