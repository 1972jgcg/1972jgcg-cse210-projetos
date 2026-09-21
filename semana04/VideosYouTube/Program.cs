using System;
using System.Collections.Generic;

class Comentario
{
    public string Nome { get; set; }
    public string Texto { get; set; }

    public Comentario(string nome, string texto)
    {
        Nome = nome;
        Texto = texto;
    }
}

class Video
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int Duracao { get; set; }
    private List<Comentario> comentarios = new List<Comentario>();

    public Video(string titulo, string autor, int duracao)
    {
        Titulo = titulo;
        Autor = autor;
        Duracao = duracao;
    }

    public void AdicionarComentario(Comentario comentario)
    {
        comentarios.Add(comentario);
    }

    public int NumeroDeComentarios()
    {
        return comentarios.Count;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Título: {Titulo}");
        Console.WriteLine($"Autor: {Autor}");
        Console.WriteLine($"Duração: {Duracao} segundos");
        Console.WriteLine($"Número de comentários: {NumeroDeComentarios()}");

        foreach (var comentario in comentarios)
        {
            Console.WriteLine($"- {comentario.Nome}: {comentario.Texto}");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Aprendiendo C#", "José", 600);
        video1.AdicionarComentario(new Comentario("João", "Ótimo trabalho!"));
        video1.AdicionarComentario(new Comentario("Maria", "Muito útil, obrigada!"));
        video1.AdicionarComentario(new Comentario("Mayra", "Gostei bastante do conteúdo"));

        Video video2 = new Video("Codificando C#", "Colina", 800);
        video2.AdicionarComentario(new Comentario("Caio", "C# é incrível!"));
        video2.AdicionarComentario(new Comentario("Pedro", "Explicação bem clara!"));
        video2.AdicionarComentario(new Comentario("Alberto", "Me ajudou muito!"));

        Video video3 = new Video("Projeto em C#", "Gonzalez", 900);
        video3.AdicionarComentario(new Comentario("Anji", "Excelente projeto"));
        video3.AdicionarComentario(new Comentario("Angel", "Agora entendi"));
        video3.AdicionarComentario(new Comentario("Freddy", "Muito bom o projeto"));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (var video in videos)
        {
            video.ExibirInformacoes();
        }
    }
}
                
    


        
              

    


    
