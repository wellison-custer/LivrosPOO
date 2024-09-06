namespace LivrosPOO;

public class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public string ISBN { get; set; }
    public bool Disponivel { get; set; }

    public Livro(string titulo, string autor, string Isbn)
    {
        Titulo = titulo;
        Autor = autor;
        ISBN = Isbn;
        Disponivel = true;
    }

    public void Emprestar() {
        if (Disponivel) {
            Disponivel = false;
            Console.WriteLine($"{Titulo} foi emprestado.");
        }
        else {
            Console.WriteLine($"{Titulo} não está disponível.");
        }
    }

    public void Devolver() {
        Disponivel = true;
        Console.WriteLine($"{Titulo} foi devolvido.");
    }
}