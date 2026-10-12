using System;
using System.Collections.Generic;

abstract class Atividade
{
    private DateTime data;
    private int duracaoMinutos;

    public Atividade(DateTime data, int duracaoMinutos)
    {
        this.data = data;
        this.duracaoMinutos = duracaoMinutos;
    }

    public DateTime Data => data;
    public int DuracaoMinutos => duracaoMinutos;

    // Métodos abstratos (contrato)
    public abstract double ObterDistancia(); // km
    public abstract double ObterVelocidade(); // km/h
    public abstract double ObterRitmo(); // min/km

    public virtual string ObterResumo()
    {
        return $"{Data:dd MMM yyyy} {GetType().Name} ({DuracaoMinutos} min) - " +
               $"Distância: {ObterDistancia():F2} km, " +
               $"Velocidade: {ObterVelocidade():F2} km/h, " +
               $"Ritmo: {ObterRitmo():F2} min/km";
    }
}