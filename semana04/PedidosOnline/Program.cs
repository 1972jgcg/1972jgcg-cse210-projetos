using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Criando primeiro cliente e pedido
        Endereco endereco1 = new Endereco("Rua Caracas", "São Paulo", "São Paulo", "Brasil");
        Cliente cliente1 = new Cliente("José", endereco1);

        Pedido pedido1 = new Pedido(cliente1);
        pedido1.AdicionarProduto(new Produto("Telefone", "T12567", 1520, 10));
        pedido1.AdicionarProduto(new Produto("Televisão", "T25465", 1800, 5));

        Console.WriteLine("----- Pedido 1 -----");
        Console.WriteLine(pedido1.GetEtiquetaEmbalagem());
        Console.WriteLine(pedido1.GetEtiquetaEnvio());
        Console.WriteLine($"Preço total: ${pedido1.GetPrecoTotal()}");

        Console.WriteLine("\n-------------------\n");

        // Criando segundo cliente e pedido
        Endereco endereco2 = new Endereco("Rua Estrada Velha Itapecerica", "São Paulo", "São Paulo", "Brasil");
        Cliente cliente2 = new Cliente("Maria", endereco2);

        Pedido pedido2 = new Pedido(cliente2);
        pedido2.AdicionarProduto(new Produto("Computador", "C245631", 2100, 2));
        pedido2.AdicionarProduto(new Produto("Mouse", "M125441", 55, 2));

        Console.WriteLine("----- Pedido 2 -----");
        Console.WriteLine(pedido2.GetEtiquetaEmbalagem());
        Console.WriteLine(pedido2.GetEtiquetaEnvio());
        Console.WriteLine($"Preço total: ${pedido2.GetPrecoTotal()}");

        Console.WriteLine("\n-----------------\n");
    }
}

public class Endereco
{
    private string Rua;
    private string Cidade;
    private string Estado;
    private string Pais;

    public Endereco(string rua, string cidade, string estado, string pais)
    {
        Rua = rua;
        Cidade = cidade;
        Estado = estado;
        Pais = pais;
    }

    public bool EhNosEUA()
    {
        return Pais.ToUpper() == "USA";
    }

    public string GetEnderecoCompleto()
    {
        return $"{Rua}\n{Cidade}, {Estado}\n{Pais}";
    }
}

public class Cliente
{
    private string Nome;
    private Endereco Endereco;

    public Cliente(string nome, Endereco endereco)
    {
        Nome = nome;
        Endereco = endereco;
    }

    public bool MoraNosEUA()
    {
        return Endereco.EhNosEUA();
    }

    public string GetNome()
    {
        return Nome;
    }

    public Endereco GetEndereco()
    {
        return Endereco;
    }
}

public class Produto
{
    private string Nome;
    private string Id;
    private double Preco;
    private int Quantidade;

    public Produto(string nome, string id, double preco, int quantidade)
    {
        Nome = nome;
        Id = id;
        Preco = preco;
        Quantidade = quantidade;
    }

    public double GetCustoTotal()
    {
        return Preco * Quantidade;
    }

    public string GetEtiqueta()
    {
        return $"{Nome} (ID: {Id})";
    }
}

public class Pedido
{
    private List<Produto> Produtos;
    private Cliente Cliente;

    public Pedido(Cliente cliente)
    {
        Cliente = cliente;
        Produtos = new List<Produto>();
    }

    public void AdicionarProduto(Produto produto)
    {
        Produtos.Add(produto);
    }

    public double GetPrecoTotal()
    {
        double total = 0;
        foreach (var p in Produtos)
        {
            total += p.GetCustoTotal();
        }
        total += Cliente.MoraNosEUA() ? 5 : 35;
        return total;
    }

    public string GetEtiquetaEmbalagem()
    {
        string etiqueta = "Produtos:\n";
        foreach (var p in Produtos)
        {
            etiqueta += p.GetEtiqueta() + "\n";
        }
        return etiqueta;
    }

    public string GetEtiquetaEnvio()
    {
        return $"Cliente: {Cliente.GetNome()}\n{Cliente.GetEndereco().GetEnderecoCompleto()}";
    }
}






    

              





    
