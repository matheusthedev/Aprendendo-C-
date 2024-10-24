// See https://aka.ms/new-console-template for more information
Console.WriteLine("Quanto você recebe?");
float salario = float.Parse(Console.ReadLine());

Console.WriteLine("Quanto você gastou esse mês?");
float gasto = float.Parse(Console.ReadLine());

if (salario >= gasto){
    Console.WriteLine("Você esta dentro do orçamento");
} else {
    Console.WriteLine("Orçamento estourado");
}
