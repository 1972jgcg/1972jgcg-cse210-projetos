using System;

class Program
{
    static void Main(string[] args)
    {
        // Cria um objeto "Tarefa" base
        Tarefa t1 = new Tarefa("Jose Colina", "Multiplicação");
        Console.WriteLine(t1.ObterResumo());

        // Agora cria os tarefas das classes derivadas
        TarefaDeMatematica t2 = new TarefaDeMatematica("Mayra Sierra", "Frações", "5.9", "5-19");
        Console.WriteLine(t2.ObterResumo());
        Console.WriteLine(t2.ObterListaDeTarefas());

        TarefaDeRedacao t3 = new TarefaDeRedacao("Jesus Colina", "História de venezuela", "A revolução e suas consequências.");
        Console.WriteLine(t3.ObterResumo());
        Console.WriteLine(t3.ObterInformacaoDaRedacao());
    }
}



