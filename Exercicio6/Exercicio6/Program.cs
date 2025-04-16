using System;
using System.Collections.Generic;

class Navegador
{
    static void Main()
    {
        Stack<string> Paginas = new Stack<string>();
        string paginaInicial = "Página Inicial";

        while (true)
        {
            Console.WriteLine("\nPágina atual: " + paginaInicial);
            Console.WriteLine("1 - Nova página");
            Console.WriteLine("2 - Voltar");
            Console.WriteLine("3 - Sair");

            string opcao = Console.ReadLine();

            if (opcao == "1")
            {
                Paginas.Push(paginaInicial);
                Console.Write("Digite a nova página: ");
                paginaInicial = Console.ReadLine();
            }

            else if (opcao == "2")
            {
                if (Paginas.Count > 0)
                {
                    paginaInicial = Paginas.Pop();
                }
                else
                {
                    Console.WriteLine("Sem páginas anteriores.");
                }
            }

            else if (opcao == "3")
            {
                break;
            }
        }
    }
}