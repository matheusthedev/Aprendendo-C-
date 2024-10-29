int[] numeros = new int[6];
int par = 0, impar = 0;

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Digite o {i + 1}º número:");
    int numeroDigitado = int.Parse(Console.ReadLine()!);
    
    // Armazenar o número digitado no array
    numeros[i] = numeroDigitado;

    if (numeroDigitado % 2 == 0) // par
    {
        par++;
    }
    else // ímpar
    {
        impar++;
    }
}

Console.WriteLine($"{par} número(s) par(es):");

for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] % 2 == 0)
    {
        Console.WriteLine($"{numeros[i]}");
    }
}

Console.WriteLine();
Console.WriteLine($"{impar} número(s) ímpar(es):");
for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] % 2 != 0)
    {
        Console.WriteLine($"{numeros[i]}");
    }
}