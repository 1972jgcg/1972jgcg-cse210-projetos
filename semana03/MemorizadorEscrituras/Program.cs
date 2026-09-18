using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Biblioteca de escrituras
        List<Escritura> biblioteca = new List<Escritura>
        {
            new Escritura(new Referencia("João", 3, 16),
                "Porque Deus amou o mundo de tal maneira que deu o seu Filho unigênito, para que todo aquele que nele crê não pereça, mas tenha a vida eterna."),

            new Escritura(new Referencia("Provérbios", 3, 5, 6),
                "Confia no Senhor de todo o teu coração, e não te estribes no teu próprio entendimento. Reconhece-o em todos os teus caminhos, e ele endireitará as tuas veredas."),

            new Escritura(new Referencia("Salmos", 23, 1),
                "O Senhor é o meu pastor, nada me faltará.")
        };

        // Escolhe uma escritura aleatória
        Random random = new Random();
        Escritura escritura = biblioteca[random.Next(biblioteca.Count)];

        while (true)
        {
            Console.Clear();
            escritura.Mostrar();

            Console.WriteLine("\nPressione Enter para continuar ou digite 'sair' para encerrar:");
            string entrada = Console.ReadLine();

            if (entrada.ToLower() == "sair") break;

            escritura.EsconderPalavrasAleatorias();

            if (escritura.TodasEscondidas())
            {
                Console.Clear();
                escritura.Mostrar();
                break;
            }
        }
    }
}

public class Referencia
{
    private string _livro;
    private int _capitulo;
    private int _versiculoInicio;
    private int _versiculoFim;

    // Construtor para um único versículo
    public Referencia(string livro, int capitulo, int versiculo)
    {
        _livro = livro;
        _capitulo = capitulo;
        _versiculoInicio = versiculo;
        _versiculoFim = versiculo;
    }

    // Construtor para intervalo de versículos
    public Referencia(string livro, int capitulo, int versiculoInicio, int versiculoFim)
    {
        _livro = livro;
        _capitulo = capitulo;
        _versiculoInicio = versiculoInicio;
        _versiculoFim = versiculoFim;
    }

    public string ObterTexto()
    {
        return _versiculoInicio == _versiculoFim
            ? $"{_livro} {_capitulo}:{_versiculoInicio}"
            : $"{_livro} {_capitulo}:{_versiculoInicio}-{_versiculoFim}";
    }
}

public class Palavra
{
    private string _texto;
    private bool _escondida;

    public Palavra(string texto)
    {
        _texto = texto;
        _escondida = false;
    }

    public void Esconder()
    {
        _escondida = true;
    }

    public string ObterTexto()
    {
        return _escondida ? new string('_', _texto.Length) : _texto;
    }

    public bool EstaEscondida()
    {
        return _escondida;
    }
}

public class Escritura
{
    private Referencia _referencia;
    private List<Palavra> _palavras;
    private Random _random = new Random();

    public Escritura(Referencia referencia, string texto)
    {
        _referencia = referencia;
        _palavras = texto.Split(" ").Select(p => new Palavra(p)).ToList();
    }

    public void Mostrar()
    {
        Console.WriteLine(_referencia.ObterTexto());
        Console.WriteLine(string.Join(" ", _palavras.Select(p => p.ObterTexto())));
    }

    public void EsconderPalavrasAleatorias(int quantidade = 3)
    {
        for (int i = 0; i < quantidade; i++)
        {
            var candidatas = _palavras.Where(p => !p.EstaEscondida()).ToList();
            if (candidatas.Count == 0) return;
            var escolhida = candidatas[_random.Next(candidatas.Count)];
            escolhida.Esconder();
        }
    }

    public bool TodasEscondidas()
    {
        return _palavras.All(p => p.EstaEscondida());
    }
}    