using System;
using System.Collections.Generic;

class Ciclismo : Atividade
{
    private double velocidadeKmH;

    public Ciclismo(DateTime data, int duracaoMinutos, double velocidadeKmH)
        : base(data, duracaoMinutos)
    {
        this.velocidadeKmH = velocidadeKmH;
    }

    public override double ObterDistancia() => (velocidadeKmH * DuracaoMinutos) / 60;

    public override double ObterVelocidade() => velocidadeKmH;

    public override double ObterRitmo() => 60 / velocidadeKmH;
}