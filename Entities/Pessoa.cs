namespace LivrosPOO;

public class Pessoa : IPessoa {
    public string Nome {get; set;}
    public string Cpf {get; set;}

    public Pessoa (string nome, string cpf) {
        Nome = nome;
        Cpf = cpf;
    }

    public virtual void obterIdentificacao(){
        Console.WriteLine($"Nome: {Nome}, CPF: {Cpf}");
    }

}