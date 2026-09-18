using System;

class Program
{
    static void Main(string[] args)
    {
         // Exibe mensagem de boas-vindas
            ExibirBoasVindas();

             // Pergunta o nome do usuário
            string nome = PerguntarNomeUsuario();

            // Pergunta o número favorito
            int numeroFavorito = PerguntarNumeroFavorito();

            // Calcula o quadrado do número favorito
            int numeroQuadrado = CalcularQuadrado(numeroFavorito);

            // Exibe o resultado
            ExibirResultado(nome, numeroQuadrado);
        }

            // Função que exibe a mensagem de boas-vindas
            static void ExibirBoasVindas()
            {
                Console.WriteLine("Bem-vindo ao programa de cálculo do quadrado do seu número favorito!");
            }
            // Função que pergunta o nome do usuário
            static string PerguntarNomeUsuario()
            {
             Console.Write("Qual é o seu nome? ");
                return Console.ReadLine();
            }

            // Função que pergunta o número favorito do usuário
            static int PerguntarNumeroFavorito()
            {
                Console.Write("Por favor, insira seu número favorito? ");
                return int.Parse(Console.ReadLine());
            }

            // Função que calcula o quadrado de um número
        static int CalcularQuadrado(int numero)      
        {
            return numero * numero;
        }

            // Função que exibe o resultado final
            static void ExibirResultado(string nome, int numeroQuadrado)
            {
                Console.WriteLine($"Obrigado, {nome}! O quadrado do seu número favorito é: {numeroQuadrado }");
    }
}