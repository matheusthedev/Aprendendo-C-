//importando as classes de dentro da pasta classes
using ClasseObjeto.Classes;

//cria o objeto animal
Animal cachorro =  new Animal();
cachorro.name = "Spaik";
cachorro.raca = "ShihTzu";
cachorro.cor = "preto e branco";
cachorro.idade = 5;

Animal gato =  new Animal();
gato.name = "Garfield";
gato.raca = "Siâmes";
gato.cor = "preto e branco";
gato.idade = 5;



Console.WriteLine($"Nome do cachorrinhho {cachorro.name}");
Console.WriteLine($"Idade do {cachorro.name} {cachorro.idade}");
Console.WriteLine($"Cor do {cachorro.name} {cachorro.cor}");
Console.WriteLine($"raça do {cachorro.name} {cachorro.raca}");

Console.WriteLine();

Console.WriteLine($"Nome do cachorrinhho {gato.name}");
Console.WriteLine($"Idade do {gato.name} {gato.idade}");
Console.WriteLine($"Cor do {gato.name} {gato.cor}");
Console.WriteLine($"raça do {gato.name} {gato.raca}");
