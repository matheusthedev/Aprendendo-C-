

namespace Construtores.Classes
{
    public class Veiculo
    {

        public string ? marca { get; set; }
        public string? modelo { get; set; }
        public int ano { get; set; }
        public string ? cor { get; set; }

        public Veiculo (string ma, string md, int an, string cr){
            marca = ma;
            modelo = md;
            ano = an;
            cor = cr;
        }
        public void ExibirDados()
        {
            Console.WriteLine(@$"
            Marca: {marca}
            Modelo: {modelo}
            Ano: {ano}
            Cor: {cor}
            ");
            
        }


    }
}