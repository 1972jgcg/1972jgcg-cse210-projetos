using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numeros = new List<int>();

        Console.WriteLine("Insira uma lista de números e digite 0 quando terminar:");

        while (true)
        {
            Console.Write("Insira um número (ou 0 para sair): ");
            int numero =  int.Parse(Console.ReadLine());
            
                if (numero == 0)
            {
                break; // Para o loop quando o usuário digitar 0
            }  

                numeros.Add(numero);
            }
            // Requisitos Básicos
            int soma = numeros.Sum();
            double media = numeros.Average();
            int maior = numeros.Max();


            Console.WriteLine($"A Soma é: {soma}");
            Console.WriteLine($"A Média é: {media}");
            Console.WriteLine($"O Maior número é: {maior}");
           
           // desafios adicionais
           if (numeros.Any(n => n > 0))
            {
                int menorPositivos = numeros.Where(n => n > 0).Min();
                Console.WriteLine($"O menor número positivo é: {menorPositivos}");
            }
            
            numeros.Sort(); // Ordena a lista em ordem crescente
            Console.WriteLine("\nNúmeros digitados em ordem crescente:");
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
    }
}