// See https://aka.ms/new-console-template for more information

// Quanto que o corinthians teve de gol?
//2
// Quanto que o palmeiras teve de gol?
//3


//se os gols forem iguais = empate
// se o corinthians teve mais gols que o palmeiras, o C ganhou
// Se o palmeiras tiveer mais gols que o C, o palmeiras ganha
Console.WriteLine("placar time 1 ?");
int time1 = int.Parse(Console.ReadLine());
Console.WriteLine("placar time 2 ?");
int time2 = int.Parse(Console.ReadLine());

if (time1 > time2)
{
    Console.WriteLine("time 1 ganhou");
}
else if (time2 > time1)
{
    Console.WriteLine("time 2 ganhou");
}
else
{
    Console.WriteLine("empate");
}
