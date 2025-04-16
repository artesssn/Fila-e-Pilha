using System;
using System.Collections.Generic;

class InverterFila
{
    static void Main()
    {
        Queue<int> fila = new Queue<int>();
        Stack<int> pilha = new Stack<int>();

        for (int i = 1; i <= 5; i++)
        {
            fila.Enqueue(i);
        }

        while (fila.Count > 0)
        {
            pilha.Push(fila.Dequeue());
        }

        while (pilha.Count > 0)
        {
            fila.Enqueue(pilha.Pop());
        }

        Console.WriteLine("Fila invertida:");

        foreach (var item in fila)
        {
            Console.Write(item + " ");
        }
    }
}