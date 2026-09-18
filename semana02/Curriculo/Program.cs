using System;

class Program
{
    static void Main(string[] args)
    {
            Curriculo curriculo1 = new Curriculo();
        curriculo1._nome = "José Colina";

        Emprego emprego1 = new Emprego();
        emprego1._cargo = "Engenheiro de Software";
        emprego1._empresa = "Microsoft";
        emprego1._anoInicio = 2020;
        emprego1._anoFim = 2023;

        Emprego emprego2 = new Emprego();
        emprego2._cargo = "Analista de Sistemas";
        emprego2._empresa = "Google";
        emprego2._anoInicio = 2023;
        emprego2._anoFim = null;

        // Adicionando empregos ao currículo
        curriculo1._empregos.Add(emprego1);
        curriculo1._empregos.Add(emprego2);

        // Exibindo currículo completo em uma chamada
        curriculo1.Exibir();
    }
}

public class Curriculo
{
    public string _nome;
    public List<Emprego> _empregos = new List<Emprego>();

    public Curriculo() {}

    // Método para exibir nome e empregos em uma linha
    public void Exibir()
    {
        Console.WriteLine($"Nome: {_nome}");
        Console.WriteLine("Experiências profissionais:");

        foreach (var emprego in _empregos)
        {
            Console.WriteLine($"{emprego._cargo} na {emprego._empresa} ({emprego._anoInicio} - {(emprego._anoFim.HasValue ? emprego._anoFim.Value.ToString() : "Atualmente")})");
        }
    }
}

public class Emprego
{
    public string _cargo;
    public string _empresa;
    public int _anoInicio;
    public int? _anoFim;

    public Emprego() {}
    }
