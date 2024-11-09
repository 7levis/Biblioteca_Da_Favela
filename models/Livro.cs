using System;

namespace Biblioteca_Da_Favela.models
{
    public class Livro 
    {
        int ID {get; set; }
        string Titulo {get; set; }
        int Ano {get; set; }
        string Autor {get; set; }
        int NumeroPaginas {get; set; }

        public Livro(int id, string titulo, int ano, string autor, int numerodepaginas)
        {
            ID = id;
            Titulo = titulo;
            Ano = ano;
            Autor = autor;
            NumeroPaginas = numerodepaginas;
        }
    }
    
}