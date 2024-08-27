namespace LivrosPOO;
public class Emprestimo {

    public Livro Livro {set; get;}
    public Cliente Cliente {set; get;}
    public DateTime DataEmprestimo {set; get;}
    public DateTime DataDevolucao {set; get;} 

    public Emprestimo (Livro livro, Cliente cliente, DateTime dataEmprestimo, DateTime dataDevolucao) {
        Livro = livro;
        Cliente = cliente;
        dataEmprestimo = dataEmprestimo;
        DataDevolucao = dataDevolucao;
    }
    
}