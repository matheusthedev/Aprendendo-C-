using System;

abstract class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    // Construtor para a classe Pessoa
    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    // Método abstrato que será implementado nas classes derivadas
    public abstract void ExibirDados();
}

class Aluno : Pessoa
{
    public int AnoEscolar { get; set; }

    // Construtor para a classe Aluno
    public Aluno(string nome, int idade, int anoEscolar) : base(nome, idade)
    {
        AnoEscolar = anoEscolar;
    }

    // Implementação do método abstrato ExibirDados
    public override void ExibirDados()
    {
        Console.WriteLine($"Aluno: {Nome}, Idade: {Idade}, Ano Escolar: {AnoEscolar}");
    }
}

class Professor : Pessoa
{
    public string Disciplina { get; set; }

    // Construtor para a classe Professor
    public Professor(string nome, int idade, string disciplina) : base(nome, idade)
    {
        Disciplina = disciplina;
    }

    // Implementação do método abstrato ExibirDados
    public override void ExibirDados()
    {
        Console.WriteLine($"Professor: {Nome}, Idade: {Idade}, Disciplina: {Disciplina}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Criação de um Aluno e um Professor
        Aluno aluno1 = new Aluno("João", 17, 2);
        Professor professor1 = new Professor("Maria", 35, "Matemática");


        // Exibindo os dados
        aluno1.ExibirDados();
        professor1.ExibirDados();
    }
}
