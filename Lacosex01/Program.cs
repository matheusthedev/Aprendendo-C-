int qtdHomem = 0;
int qtdMulher = 0;
int qtdEsporte = 0;
int qtdnEsportes = 0;
Console.WriteLine($"Quantas pessoas tem na sua mesa ?");

int qtdDeEntrevistados = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= qtdDeEntrevistados; i++)
{
    Console.WriteLine($"Qual é o seu sexo? m/f");
    string sexo = Console.ReadLine();


    if (sexo == "f")
    {
        qtdMulher++;
    }
    else if (sexo == "m")
    {
        qtdHomem++;
    }

    Console.WriteLine($"Você gost de esporte? s/n");
    string esporte = Console.ReadLine();

    if (esporte == "s")
    {
        qtdEsporte++;
    }
    else
    {
        qtdnEsportes++;
    }
}

Console.WriteLine(@"------------------------------------------------------------------------");
Console.WriteLine($"Quantidade de mulheres: {qtdMulher}");
Console.WriteLine($"Quantidade de homens: {qtdHomem}");
Console.WriteLine($"Quantidade de pessoas da mesa que gostam de esporte: {qtdEsporte}");
Console.WriteLine($"Quantidade de pessoas que não gostam de esportes: {qtdnEsportes}");
Console.WriteLine($"Quantidade de entrevistados: {qtdMulher + qtdHomem}");