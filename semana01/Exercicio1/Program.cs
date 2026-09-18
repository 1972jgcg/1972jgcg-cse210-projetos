using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine($"Olá, {nome}!");
            Console.Write("Digite sua sobrenome: ");
            string sobrenome = Console.ReadLine();
            Console.WriteLine($"Seu nome é: {sobrenome}, {nome} {sobrenome}");
    }
}