namespace LivrosPOO;
public class Emprestimo
{

    public Livro Livro { set; get; }
    public Cliente Cliente { set; get; }
    public DateTime DataEmprestimo { set; get; }
    public DateTime DataDevolucao { set; get; }

    public Emprestimo(Livro livro, Cliente cliente, DateTime dataEmprestimo, DateTime dataDevolucao)
    {
        Livro = livro;
        Cliente = cliente;
        dataEmprestimo = dataEmprestimo;
        DataDevolucao = dataDevolucao.AddDays(14);
    }

    public void ConcluirEmprestimo()
    {
        Livro.Emprestar();
        Console.WriteLine($"Emprestimo concluído para o cliente {Cliente.Nome}. Data de devolução: {DataDevolucao.ToShortDateString()}");
    }

    public void DevolverLivro()
    {
        Livro.Devolver();
        Console.WriteLine($"Livro {Livro.Titulo} devolvido pelo cliente {Cliente.Nome}");
    }

}