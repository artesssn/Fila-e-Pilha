using System;
using System.Collections.Generic;

class Item
{
    public string Nome { get; set; }
    public int Prioridade { get; set; }

    public Item(string nome, int prioridade)
    {
        Nome = nome;
        Prioridade = prioridade;
    }
}

class FilaPrioridade
{
    List<Item> fila = new();

    public void Enfileirar(string nome, int prioridade)
    {
        fila.Add(new Item(nome, prioridade));
        Console.WriteLine($"Enfileirado: {nome} (Prioridade {prioridade})");
    }

    public void Atender()
    {
        if (fila.Count == 0)
        {
            Console.WriteLine("Fila vazia!");
            return;
        }

        var proximo = fila[0];
        foreach (var item in fila)
            if (item.Prioridade < proximo.Prioridade)
                proximo = item;

        fila.Remove(proximo);
        Console.WriteLine($"Atendido: {proximo.Nome} (Prioridade {proximo.Prioridade})");
    }

    public void Mostrar()
    {
        Console.WriteLine("Fila atual:");
        foreach (var item in fila)
            Console.WriteLine($"- {item.Nome} (Prioridade {item.Prioridade})");
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        var fila = new FilaPrioridade();
        fila.Enfileirar("Rafael", 3);
        fila.Enfileirar("Bruno", 1);
        fila.Enfileirar("Daniel", 2);
        fila.Enfileirar("Ribas", 4);
        fila.Enfileirar("Lazy Town", 5);
        fila.Mostrar();
        fila.Atender();
        fila.Mostrar();
    }
}