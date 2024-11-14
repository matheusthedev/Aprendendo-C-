
using Construtores.Classes;


//Construtores

AlunoDois matheusReis = new AlunoDois("Matheus Reis");
matheusReis.cpf = 13443;

AlunoDois kaykyNascimento = new AlunoDois("Kayky Nascimento");
kaykyNascimento.cpf = 12345;

AlunoDois eduCosta = new AlunoDois();

AlunoDois zezao = new AlunoDois("Herik Spada", 1234);
Console.WriteLine($"{zezao.Nome}");
Console.WriteLine($"{zezao.cpf}");



Console.WriteLine($"{matheusReis.Nome}");
Console.WriteLine($"{matheusReis.cpf}");


// Veiculo carro1 = new Veiculo("Ford", "Ka", 2000, "vermelho ");
// Veiculo carro2 = new Veiculo("Ford", "Mustang", 1995, "preto");

// carro1.marca = "Ford";
// carro1.modelo = "Ka";
// carro1.ano = 2000;
// carro1.cor = "Vermelho";

// carro2.marca = "Ford";
// carro2.modelo = "Mustang";

// carro1.ExibirDados();
// carro2.ExibirDados();

// Console.WriteLine($"Area dos Alunos-------------");


// Aluno aluno1 = new Aluno("João", 18, "0001103268901sp");
// Aluno aluno2 = new Aluno("Matheus", 17, "0001103252501sp");

// aluno1.ExibirDados();
// aluno2.ExibirDados();





// int opcao;
// string nome;
// string DtLancamento;
// string genero;
// float preco;
// Console.WriteLine($"Area de Jogos -----------");

// do
// {
    
// Console.WriteLine(@$"
// -----------Menu De opções------------
// 1) Cadastrar Jogo
// 2) Listar Jogos
// 0) Sair.");
//  opcao = int.Parse(Console.ReadLine()!);

// if (opcao == 1)
// {
//     Console.WriteLine($"Você escolheu a opcao cadastrar jogo!");
//     Console.WriteLine($"");

//     Console.Write($"Iforme o nome do seu jogo: ");
//      nome = Console.ReadLine()!;

//     Console.Write($"Iforme a data de lançamento do seu jogo: ");
//      DtLancamento = Console.ReadLine()!;

//     Console.Write($"Iforme o Genêro do seu jogo: ");
//     genero = Console.ReadLine()!;

//     Console.Write($"Iforme o preço do seu jogo: ");
//     preco = float.Parse(Console.ReadLine()!);

// } else if (opcao == 2){
//     Console.WriteLine($"Você escolheu a opcao listar jogos!");
//     Console.WriteLine($"");
    
//     Console.WriteLine($"Nomde do jogo: {}");
    
    
// }

// } while (opcao != 0);

// Console.WriteLine($"Você escolheu a opção sair!");








// List<Jogo> estoqueJogos = new List<Jogo>();

// Jogo jogo1 = new Jogo("FIFA", 2025, "Futebol", 250);
// Jogo jogo2 = new Jogo("Call of duty", 2024, "Ação", 250);
// Jogo jogo3 = new Jogo("Fortnite", 2017, "Ação", 10);
// Jogo jogo4 = new Jogo("Rainbow six", 2016, "Ação", 60);

// estoqueJogos.Add(jogo1);
// estoqueJogos.Add(jogo2);
// estoqueJogos.Add(jogo3);
// estoqueJogos.Add(jogo4);

// foreach (var jogo   in estoqueJogos)
// {
//     jogo.ExibirDados();
//     Console.WriteLine($"");
    
    
    
// }
// jogo1.ExibirDados();
// jogo2.ExibirDados();