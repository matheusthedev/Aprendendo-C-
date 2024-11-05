//importando as classes de dentro da pasta classes
using ClasseObjeto.Classes;

//cria o objeto animal
Animal cachorro =  new Animal();
cachorro.nome = "Spaik";
cachorro.raca = "ShihTzu";
cachorro.cor = "preto e branco";
cachorro.idade = 5;

Animal gato =  new Animal();
gato.nome = "Garfield";
gato.raca = "Siâmes";
gato.cor = "preto e branco";
gato.idade = 5;


cachorro.FazerBarulho("Au Au");
// Console.WriteLine($"Nome do cachorrinhho {cachorro.nome}");
Console.WriteLine($"Idade do {cachorro.nome} {cachorro.idade}");
cachorro.Envelhecer();
Console.WriteLine ($"Nova idade de {cachorro.nome} {cachorro.idade}");
// Console.WriteLine($"Cor do {cachorro.nome} {cachorro.cor}");
// Console.WriteLine($"raça do {cachorro.nome} {cachorro.raca}");

Console.WriteLine();

gato.FazerBarulho("Miau");
// Console.WriteLine($"Nome do cachorrinhho {gato.nome}");
Console.WriteLine($"Idade do {gato.nome} {gato.idade}");
gato.Envelhecer();
Console.WriteLine ($"Nova idade de {gato.nome} {gato.idade}");
// Console.WriteLine($"Cor do {gato.nome} {gato.cor}");
// Console.WriteLine($"raça do {gato.nome} {gato.raca}");


