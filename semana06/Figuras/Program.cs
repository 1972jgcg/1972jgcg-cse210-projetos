using System;

class Program
{
  public static void Main(string[] args)
    {
      // Criando lista de figuras
        List<Figura> figuras = new List<Figura>();

        // Adicionando diferentes tipos de figuras
        figuras.Add(new Quadrado("Vermelho", 4));
        figuras.Add(new Retangulo("Azul", 5, 3));
        figuras.Add(new Circulo("Verde", 2));

        // Percorrendo a lista e exibindo cor e área
        foreach (Figura figura in figuras)
        {
            Console.WriteLine($"Figura: {figura.GetType().Name}, Cor: {figura.Cor}, Área: {figura.ObterArea()}");
        }
    }
}