using JogoRpg;
Console.Clear();

Rpg Personagem1 = new Rpg();

// Personagem1.nome = "Steve";
// Personagem1.idade = 22;
// Personagem1.armadura = "Armadura de pegasus";
// Personagem1.ia = "Yui";

Console.Write($"Informe seu NickName: ");
string nome = Console.ReadLine()!;

Console.Write($"Informe sua Idade: ");
int idade = int.Parse(Console.ReadLine()!);

Console.Write($"Informe sua armadura: ");
string armadura = Console.ReadLine()!;

Console.Write($"Informe sua I.A: ");
string ia = Console.ReadLine()!;

Console.WriteLine($"");


Console.WriteLine($"Nome do personagem: {nome}");
Console.WriteLine($"Idade do personagem: {idade}");
Console.WriteLine($"Armadura do personagem: {armadura}");
Console.WriteLine($"I.A do personagem: {ia}");

Console.WriteLine($"");


Personagem1.Atacar();
Personagem1.RestaurarArmadura();
Personagem1.Defendeu();
