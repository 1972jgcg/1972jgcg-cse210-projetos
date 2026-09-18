using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        Diario meuDiario = new Diario();
        List<string> perguntas = new List<string> {
            "Que precisa fazer para ser feliz?",
            "Qual foi a melhor parte do meu dia?",
            "Qual foi a emoção mais forte que senti hoje?",
            "Se eu pudesse fazer uma coisa hoje, o que seria?",
            "Como vi a mão do Senhor em minha vida hoje?"
        };

        bool continuar = true;
        Random rnd = new Random();

        while (continuar)
        {
            Console.WriteLine("\n--- MENU ---");
            Console.WriteLine("1. Escrever novo registro");
            Console.WriteLine("2. Exibir diário");
            Console.WriteLine("3. Salvar diário");
            Console.WriteLine("4. Carregar diário");
            Console.WriteLine("5. Sair");
            Console.WriteLine("6. Salvar em JSON");
            Console.WriteLine("7. Carregar de JSON");
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    string pergunta = perguntas[rnd.Next(perguntas.Count)];
                    Console.WriteLine(pergunta);
                    string resposta = Console.ReadLine();
                    string data = DateTime.Now.ToShortDateString();
                    meuDiario.AdicionarRegistro(pergunta, resposta, data);
                    break;

                case "2":
                    meuDiario.ExibirRegistros();
                    break;

                case "3":
                    Console.Write("Digite o nome do arquivo para salvar: ");
                    string nomeSalvar = Console.ReadLine();
                    meuDiario.Salvar(nomeSalvar);
                    Console.WriteLine("Diário salvo com sucesso!");
                    break;

                case "4":
                    Console.Write("Digite o nome do arquivo para carregar: ");
                    string nomeCarregar = Console.ReadLine();
                    meuDiario.Carregar(nomeCarregar);
                    Console.WriteLine("Diário carregado com sucesso!");
                    break;

                case "5":
                    continuar = false;
                    break;

                case "6":
                    Console.Write("Digite o nome do arquivo JSON para salvar: ");
                    string nomeJSONSalvar = Console.ReadLine();
                    meuDiario.SalvarJSON(nomeJSONSalvar);
                    Console.WriteLine("Diário salvo em JSON com sucesso!");
                    break;

                case "7":
                    Console.Write("Digite o nome do arquivo JSON para carregar: ");
                    string nomeJSONCarregar = Console.ReadLine();
                    meuDiario.CarregarJSON(nomeJSONCarregar);
                    Console.WriteLine("Diário carregado de JSON com sucesso!");
                    break;

                default:
                    Console.WriteLine("José, só existem opções de 1 a 7. Tente novamente.");
                    break;
            }
        }
    }
}

class Registro
{
    public string Pergunta { get; set; }
    public string Resposta { get; set; }
    public string Data { get; set; }

    public Registro(string pergunta, string resposta, string data)
    {
        Pergunta = pergunta;
        Resposta = resposta;
        Data = data;
    }

    public override string ToString()
    {
        return $"{Data} | {Pergunta} | {Resposta}";
    }
}

class Diario
{
    private List<Registro> registros = new List<Registro>();

    public void AdicionarRegistro(string pergunta, string resposta, string data)
    {
        Registro novo = new Registro(pergunta, resposta, data);
        registros.Add(novo);
    }

    public void ExibirRegistros()
    {
        foreach (Registro r in registros)
        {
            Console.WriteLine(r);
        }
    }

    public void Salvar(string nomeArquivo)
    {
        using (StreamWriter arquivo = new StreamWriter(nomeArquivo))
        {
            foreach (Registro r in registros)
            {
                arquivo.WriteLine($"{r.Data}|{r.Pergunta}|{r.Resposta}");
            }
        }
    }

    public void Carregar(string nomeArquivo)
    {
        registros.Clear();
        string[] linhas = File.ReadAllLines(nomeArquivo);
        foreach (string linha in linhas)
        {
            string[] partes = linha.Split('|');
            if (partes.Length == 3)
            {
                Registro r = new Registro(partes[1], partes[2], partes[0]);
                registros.Add(r);
            }
        }
    }

    public void SalvarJSON(string nomeArquivo)
    {
        string json = JsonSerializer.Serialize(registros);
        File.WriteAllText(nomeArquivo, json);
    }

    public void CarregarJSON(string nomeArquivo)
    {
        string json = File.ReadAllText(nomeArquivo);
        registros = JsonSerializer.Deserialize<List<Registro>>(json);
    }
}
