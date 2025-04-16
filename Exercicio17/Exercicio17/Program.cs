using System;
using System.Collections.Generic;
enum Prioridade { Alta, Baixa }
class Documento
{
    public string Nome { get; }
    public Prioridade Prioridade { get; }
    public Documento(string nome, Prioridade prioridade)
    {
        Nome = nome;
        Prioridade = prioridade;
    }
}
class GerenciadorImpressao
{
    Queue<string> normal = new();
    Queue<string> prioritaria = new();
    public void Adicionar(string nome, Prioridade prioridade)
    {
        if (prioridade == Prioridade.Alta) prioritaria.Enqueue(nome);
        else normal.Enqueue(nome);

        Console.WriteLine($"Documento '{nome}' adicionado à fila {(prioridade == Prioridade.Alta ? "Prioritária" : "Normal")}\n");
    }
    public void Imprimir()
    {
        Console.WriteLine();
        while (prioritaria.Count > 0)
            Console.WriteLine("Imprimindo: " + prioritaria.Dequeue());
        while (normal.Count > 0)
            Console.WriteLine("Imprimindo: " + normal.Dequeue());
    }
    public void Mostrar()
    {
        Console.WriteLine();

        if (prioritaria.Count == 0 && normal.Count == 0)
        {
            Console.WriteLine("Fila vazia!");
            return;
        }

        if (prioritaria.Count > 0)
        {
            Console.WriteLine("Fila Prioritária:");
            foreach (var doc in prioritaria)
                Console.WriteLine("- " + doc);
        }

        if (normal.Count > 0)
        {
            Console.WriteLine("\nFila Normal:");
            foreach (var doc in normal)
                Console.WriteLine("- " + doc);
        }

        Console.WriteLine();
    }
}
class Program
{
    static void Main()
    {
        var g = new GerenciadorImpressao();
        g.Adicionar("Desenho", Prioridade.Baixa);
        g.Adicionar("Laudo Médico", Prioridade.Alta);
        g.Adicionar("Papel Timbrado", Prioridade.Baixa);
        g.Adicionar("Exames", Prioridade.Alta);

        g.Mostrar();
        g.Imprimir();
        g.Mostrar();
    }
}