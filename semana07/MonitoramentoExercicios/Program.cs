using System;

class Program
{
    static void Main(string[] args)
    {
         List<Atividade> atividades = new List<Atividade>
         {
            new Corrida(new DateTime(2022, 11, 3), 30, 4.8),
            new Ciclismo(new DateTime(2022, 11, 3), 45, 20.0),
            new Natacao(new DateTime(2022, 11, 3), 25, 40)
        };

        foreach (var atividade in atividades)
        {
            Console.WriteLine(atividade.ObterResumo());
        }
    }
}
    
