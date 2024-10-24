Console.WriteLine(@"
+--------------------------------------+
|          Seja Bem Vindo              |
+--------------------------------------+
|    Por Favor Digite seus Dados       |
+--------------------------------------+");


Console.WriteLine($"Ola, Digite Seu Nome: ");
string nome = Console.ReadLine()!;

Console.WriteLine($"Ola, {nome} Digite Seu Sobrenome: ");
string sobrenome = Console.ReadLine()!;



Console.WriteLine($"Informe seu email: ");
string Email = Console.ReadLine()!;

Console.WriteLine($"Informe Seu telefone: ");
uint Telefone = uint.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite seu CPF: ");
uint CPF = uint.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite seu endereço: ");
string endereço = Console.ReadLine()!;

Console.WriteLine($"Qual seu estado civil: ");
string EstadoCivil = Console.ReadLine()!;

float anoNascimento = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Informe sua Data de nascimento: ");
int DataNascimento = int.Parse(Console.ReadLine()!);
int anoAtual = DateTime.Now.Year;
int idade = anoAtual - DataNascimento;


Console.Clear();
Console.WriteLine(
    $"Dados Cadastrados: {nome} {sobrenome} \n Idade: {idade} \n Email: {Email} \n Telefone: {Telefone} \n CPF: {CPF} \n Endereço: {endereço} \n EstadoCivil: {EstadoCivil}");