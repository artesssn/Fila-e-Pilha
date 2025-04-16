using System;
using System.Collections.Generic;

class Atendimento
{
    static void Main()
    {
        Queue<string> Atendimento = new Queue<string>();

        while (true)
        {
            Console.WriteLine("1. Adicionar cliente");
            Console.WriteLine();
            Console.WriteLine("2. Atender cliente");
            Console.WriteLine("3. Sair");

            string opcao = Console.ReadLine();

            if (opcao == "1")
            {
                Console.WriteLine("Nome do cliente: ");
                string nome = Console.ReadLine();
                Atendimento.Enqueue(nome);
            }

            else if (opcao == "2")
            {
                if (Atendimento.Count > 0)
                {
                    Console.WriteLine("Atendendo: " + Atendimento.Dequeue());
                }

                else
                {
                    Console.WriteLine("Fila vazia.");
                }
            }

            else if (opcao == "3")
            {
                break;
            }
        }
    }
}