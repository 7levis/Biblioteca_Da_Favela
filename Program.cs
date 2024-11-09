using System;
using Biblioteca_Da_Favela.services;

namespace Biblioteca_Da_Favela
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nBem vindo, Ao Gestor de Biblioteca");
            Console.WriteLine("1. Adicionar Livro");
            Console.WriteLine("2. Deletar Livro");
            Console.WriteLine("3. Atualizar Livro");
            Console.WriteLine("4. Exibir Inventário");

            string opcao = Console.ReadLine();

            while (opcao != "0")
            {
                
                if(opcao == "1")
                {
                    LivroService.Adicionar();
                }
                else if(opcao == "2")
                {
                    LivroService.Remover();
                }
                else if(opcao == "3")
                {
                    LivroService.Atualizar();
                }
                else if(opcao == "4")
                {
                    LivroService.Exibir();
                }

                Console.WriteLine("Saindo...");
            }
            
        }
    }
}
