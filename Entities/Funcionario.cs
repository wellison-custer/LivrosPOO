namespace LivrosPOO;

public class Funcionario : Pessoa {
    protected int Id_Funcionario {get; set;}
    
    public Funcionario(int id_funcionario, string nome, string cpf) : base(nome, cpf) {
        Id_Funcionario = id_funcionario;
    }

    public override void obterIdentificacao() {
        Console.WriteLine($"Id_Funcionario: {Id_Funcionario} Nome: {Nome}, CPF: {Cpf}");
    }
}