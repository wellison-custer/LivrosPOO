namespace LivrosPOO;

public class Pessoa : IPessoa {
    protected string Nome {get; set;}
    protected string Cpf {get; set;}

    public Pessoa (string nome, string cpf) {
        Nome = nome;
        Cpf = cpf;
    }

    public virtual void obterIdentificacao(){
        Console.WriteLine($"Nome: {Nome}, CPF: {Cpf}");
    }

}