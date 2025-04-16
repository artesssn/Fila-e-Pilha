using System;

class FilaCircular
{
    int[] dados;
    int frente = 0, tras = 0, tamanho = 0;
    int capacidade;

    public FilaCircular(int capacidade)
    {
        this.capacidade = capacidade;
        dados = new int[capacidade];
    }

    public void Enqueue(int valor)
    {
        if (tamanho == capacidade)
        {
            Console.WriteLine("Fila cheia!");
            return;
        }

        dados[tras] = valor;
        tras = (tras + 1) % capacidade;
        tamanho++;
        Console.WriteLine($"Enfileirado: {valor}");
    }

    public void Dequeue()
    {
        if (tamanho == 0)
        {
            Console.WriteLine("Fila vazia!");
            return;
        }

        int removido = dados[frente];
        frente = (frente + 1) % capacidade;
        tamanho--;
        Console.WriteLine($"Removido: {removido}");
    }

    public void Mostrar()
    {
        Console.Write("Fila: ");
        for (int i = 0; i < tamanho; i++)
        {
            int index = (frente + i) % capacidade;
            Console.Write(dados[index] + " ");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        var fila = new FilaCircular(5);

        fila.Enqueue(1);
        fila.Enqueue(2);
        fila.Enqueue(3);
        fila.Enqueue(4);
        fila.Enqueue(5);
        fila.Mostrar();

        fila.Dequeue();
        fila.Dequeue();
        fila.Mostrar();

        fila.Enqueue(6);
        fila.Enqueue(7);
        fila.Mostrar();
    }
}