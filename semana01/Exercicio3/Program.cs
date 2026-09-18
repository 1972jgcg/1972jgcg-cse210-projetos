using System;

class Program
{
    static void Main(string[] args)
    {
        bool jogarNovamente = true;

            while (jogarNovamente)
            {
                Random random = new Random();
                int numeroMagico = random.Next(1, 101);

                int palpite = -1;
                int tentativas = 0;

                Console.WriteLine("Bem-vindo ao jogo do número mágico!");

                while (palpite != numeroMagico)
                {
                    Console.Write("Digite seu palpite (1 a 100): ");
                    string entrada = Console.ReadLine();

                    // Validação de entrada
                    if (!int.TryParse(entrada, out int palpiteValido))
                    {
                        Console.WriteLine("Por favor, digite um número válido.");
                        continue;
                    }
                    palpite = palpiteValido; // aquí actualizamos correctamente
                    tentativas++;

                    if (palpite < numeroMagico)
                    {
                        Console.WriteLine("Muito baixo! Tente novamente.");
                    }
                    else if (palpite > numeroMagico)
                    {
                        Console.WriteLine("Muito alto! Tente novamente.");
                    }
                    else
                    {
                        Console.WriteLine($"Parabéns! Você acertou o número mágico em {tentativas} tentativas!");
                    }
                }

                // Perguntar se quer jogar novamente
                Console.Write("Deseja jogar novamente? (s/n): ");
                string resposta = Console.ReadLine()?.Trim().ToLower();
                jogarNovamente = (resposta == "s");
            }

            Console.WriteLine("Obrigado por jogar! Até a próxima!");
    }
}