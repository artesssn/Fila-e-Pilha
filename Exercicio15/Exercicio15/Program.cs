using System;
using System.Collections.Generic;

class Estacionamento
{
    private Stack<string> pilha = new Stack<string>();
    private const int capacidade = 5;

    public void EntrarCarro()
    {
        if (pilha.Count >= capacidade)
        {
            Console.WriteLine("Estacionamento cheio!");
            return;
        }

        Console.Write("Digite a placa do carro: ");
        string placa = Console.ReadLine();
        pilha.Push(placa);
        Console.WriteLine($"Carro {placa} estacionou!");
    }

    public void RetirarCarro()
    {
        Console.Write("Digite a placa do carro a ser retirado: ");
        string placa = Console.ReadLine();

        if (!pilha.Contains(placa))
        {
            Console.WriteLine($"Carro {placa} não está no estacionamento.");
            return;
        }

        Stack<string> temp = new Stack<string>();

        while (pilha.Peek() != placa)
        {
            temp.Push(pilha.Pop());
            Console.WriteLine("Carro retirado temporariamente.");
        }

        pilha.Pop();
        Console.WriteLine($"Carro {placa} foi retirado!");

        while (temp.Count > 0)
        {
            pilha.Push(temp.Pop());
        }
    }

    public void Mostrar()
    {
        Console.WriteLine("Carros no estacionamento:");
        foreach (var carro in pilha)
        {
            Console.WriteLine(carro);
        }
        if (pilha.Count == 0) Console.WriteLine("(vazio)");
    }
}

class Program
{
    static void Main()
    {
        Estacionamento est = new Estacionamento();
        string opcao;

        do
        {
            Console.WriteLine("1 - Entrar carro");
            Console.WriteLine("2 - Retirar carro");
            Console.WriteLine("3 - Mostrar estacionamento");
            Console.WriteLine("4 - Sair");
            Console.Write("Opção: ");
            opcao = Console.ReadLine();
            Console.Clear();

            switch (opcao)
            {
                case "1": est.EntrarCarro(); break;
                case "2": est.RetirarCarro(); break;
                case "3": est.Mostrar(); break;
                case "4": Console.WriteLine("Saindo..."); break;
                default: Console.WriteLine("Opção inválida."); break;
            }
        } while (opcao != "4");
    }
}