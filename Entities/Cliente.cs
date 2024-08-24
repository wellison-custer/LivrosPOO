namespace LivrosPOO;

public class Cliente : Pessoa {
    protected int Id_cliente {get; set;}
    public Cliente(int id_cliente,string nome, string cpf) : base(nome, cpf) {
        Id_cliente = id_cliente;
    }

    public override void obterIdentificacao() {
        Console.WriteLine($"Id_Cliente: {Id_cliente} Nome: {Nome}, CPF: {Cpf}");
    }
}

    