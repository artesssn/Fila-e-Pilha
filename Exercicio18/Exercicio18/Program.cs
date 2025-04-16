using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] expr = "3 4 + 2 *".Split();
        Stack<int> pilha = new();

        foreach (var t in expr)
        {
            if (int.TryParse(t, out int n))
            {
                pilha.Push(n);
            }
            else
            {
                switch (t)
                {
                    case "+":
                        pilha.Push(pilha.Pop() + pilha.Pop());
                        break;
                    case "-":
                        pilha.Push(-pilha.Pop() + pilha.Pop());
                        break;
                    case "*":
                        pilha.Push(pilha.Pop() * pilha.Pop());
                        break;
                    case "/":
                        int b = pilha.Pop();
                        int a = pilha.Pop();
                        pilha.Push(a / b);
                        break;
                }
            }
        }

        Console.WriteLine($"Resultado: {pilha.Pop()}");
    }
}