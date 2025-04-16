using System;
using System.Collections.Generic;

class Deque
{
    Queue<int> fila = new();

    public void InserirFrente(int valor)
    {
        var nova = new Queue<int>();
        nova.Enqueue(valor);
        foreach (var item in fila) nova.Enqueue(item);
        fila = nova;
    }

    public void InserirTras(int valor) => fila.Enqueue(valor);

    public void RemoverFrente()
    {
        if (fila.Count == 0) Console.WriteLine("Deque vazio");
        else Console.WriteLine("Removido: " + fila.Dequeue());
    }

    public void RemoverTras()
    {
        if (fila.Count == 0)
        {
            Console.WriteLine("Deque vazio");
            return;
        }

        var nova = new Queue<int>();
        while (fila.Count > 1) nova.Enqueue(fila.Dequeue());
        Console.WriteLine("Removido: " + fila.Dequeue());
        fila = nova;
    }

    public void Mostrar()
    {
        Console.WriteLine("Fila: " + string.Join(" ", fila));
    }
}

class Program
{
    static void Main()
    {
        var deque = new Deque();

        deque.InserirTras(1);
        deque.InserirFrente(2);
        deque.InserirTras(3);
        deque.InserirFrente(4);

        deque.Mostrar();

        deque.RemoverFrente();
        deque.RemoverTras();

        deque.Mostrar();
    }
}