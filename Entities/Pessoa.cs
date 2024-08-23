namespace LivrosPOO;

public abstract class Pessoa : IPessoa {
    private string Nome {get; set;}
    private string Cpf {get; set;}

    public Pessoa (string nome, string cpf) {
        Nome = nome;
        Cpf = cpf;
    }
    public void obterIdentificacao(){
        Console.WriteLine($"Nome: {Nome}, CPF: {Cpf}");
    }

}