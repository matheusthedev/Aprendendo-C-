

namespace Construtores.Classes
{
    public class Jogo
    {
        public string? nome;
        public int? lancamento;
        public string? genero;
        public float preco;

        public Jogo(string nm, int lanc, string gen, float pr){
            nome = nm;
            lancamento = lanc;
            genero = gen;
            preco = pr;
        }

        public void ExibirDados()
        {
            Console.WriteLine(@$"
            Nome do Jogo: {nome}
            Data de lançamento do jogo: {lancamento}
            Genêro do jogo: {genero}
            Preço do jogo: {preco}");
    }
    }
}