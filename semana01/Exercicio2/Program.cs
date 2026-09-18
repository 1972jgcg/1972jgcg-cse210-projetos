using System;

class Program
{
    static void Main(string[] args)
    {
         Console.Write("Digite sua nota numérica: ");
            int nota = int.Parse(Console.ReadLine());

            string letra;
            if (nota >= 90)
            letra = "A";
            else if (nota >= 80)
            letra = "B";
            else if (nota >= 70)
            letra = "C";
            else if (nota >= 60)
            letra = "D";
            else 
            letra = "F";

            // Determinar o sinal (+ ou -) com base na nota
            string sinal = "";
            int ultimoDigito = nota % 10;
        
            if (letra != "F") // Não adicionar sinal para notas F
            {
                if (letra == "A" && ultimoDigito >= 7)

                // não existe A+, apenas A ou A-
                sinal = "-";
                else if (ultimoDigito >= 7)
                sinal = "+";
                else if (ultimoDigito <= 3)
                sinal = "-"; 
            }
    
            Console.WriteLine($"Sua nota conceitual é: {letra}{sinal}");

            if (nota >= 70)
            Console.WriteLine("Parabéns! Você foi aprovado!");
            else
            Console.WriteLine("Infelizmente, você não foi aprovado. continue tentando!");

    }
}