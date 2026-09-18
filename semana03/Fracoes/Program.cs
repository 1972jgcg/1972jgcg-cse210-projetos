using System;

class Program
{
    static void Main(string[] args)
    {
         // Aqui você pode testar sua classe Fracoes
        Fracoes f1 = new Fracoes();          // 1/1
        Fracoes f2 = new Fracoes(5);         // 5/1
        Fracoes f3 = new Fracoes(3, 4);      // 3/4
        Fracoes f4 = new Fracoes(1, 3);      // 1/3


        Console.WriteLine(f1.ObterFracoesEmTexto());   // "1/1"
        Console.WriteLine(f2.ObterFracoesEmTexto());   // "5/1"
        Console.WriteLine(f3.ObterFracoesEmTexto());   // "3/4"
        Console.WriteLine(f4.ObterFracoesEmTexto());   // "1/3"
        
        Console.WriteLine(f1.ObterFracoesEmDecimal()); // 1.0
        Console.WriteLine(f2.ObterFracoesEmDecimal()); // 5.0
        Console.WriteLine(f3.ObterFracoesEmDecimal()); // 0.75
        Console.WriteLine(f4.ObterFracoesEmDecimal()); // 0,33
    }
}
public class Fracoes
{
    private int _numerador;
    private int _denominador;

    // 🔹 Construtor sem parâmetros → inicializa como 1/1
    public Fracoes()
    {
        _numerador = 1;
        _denominador = 1;
    }

    // 🔹 Construtor com um parâmetro (numerador) → denominador = 1
    public Fracoes(int numeroInteiro)
    {
        _numerador = numeroInteiro;
        _denominador = 1;
    }

    // 🔹 Construtor com dois parâmetros (numerador e denominador)
    public Fracoes(int numerador, int denominador)
    {
        _numerador = numerador;
        _denominador = denominador == 0 ? 1 : denominador; // evita zero
    }

    // Métodos de acesso
    public int ObterNumerador()
    {
        return _numerador;
    }

    public void DefinirNumerador(int numerador)
    {
        _numerador = numerador;
    }

    public int ObterDenominador()
    {
        return _denominador;
    }

    public void DefinirDenominador(int denominador)
    {
        _denominador = denominador == 0 ? 1 : denominador;
    }

    // Retorna a fração como texto
    public string ObterFracoesEmTexto()
    {
        return $"{_numerador}/{_denominador}";
    }

    // Retorna a fração como número decimal
    public double ObterFracoesEmDecimal()
    {
        return (double)_numerador / _denominador;
    }
}