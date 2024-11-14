

namespace Construtores.Classes
{
    public class Aluno
    {

        public string? nome;
        public int idade;
        public string? matricula;

        public Aluno(string nm, int id, string mat)
        {
            nome = nm;
            idade = id;
            matricula = mat;
        }

        public void ExibirDados()
        {
            Console.WriteLine(@$"
            Nome do aluno: {nome}
            Idade do aluno: {idade}
            Matricula do aluno: {matricula}");
        }
    }
}