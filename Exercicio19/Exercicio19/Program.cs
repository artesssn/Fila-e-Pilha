using System;
using System.Collections.Generic;

class Program
{
    static Stack<string> desfazer = new();
    static Stack<string> refazer = new();

    static void Main()
    {
        string palavra;
        do
        {
            Console.Write("Digite uma ação (desfazer, refazer ou sair): ");
            palavra = Console.ReadLine();

            if (palavra == "undo")
            {
                if (desfazer.Count > 0)
                {
                    string acao = desfazer.Pop();
                    refazer.Push(acao);
                    Console.WriteLine($"Desfez: {acao}");
                }
                else Console.WriteLine("Nada a desfazer.");
            }
            else if (palavra == "redo")
            {
                if (refazer.Count > 0)
                {
                    string acao = refazer.Pop();
                    desfazer.Push(acao);
                    Console.WriteLine($"RefFez: {acao}");
                }
                else Console.WriteLine("Nada a refazer.");
            }
            else if (palavra != "sair")
            {
                desfazer.Push(palavra);
                refazer.Clear();
                Console.WriteLine($"Ação registrada: {palavra}");
            }

        } while (palavra != "sair");
    }
}
