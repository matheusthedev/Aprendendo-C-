float[] temperaturas = new float[12]; // Declare and initialize the temperatures array

for (int i = 0; i < 12; i++)
{
    Console.WriteLine($"Quantos graus esta nesse mês {i + 1}?");
    temperaturas[i] = Convert.ToSingle(Console.ReadLine());
}

float maiorTemperatura = temperaturas[0]; // Initialize maiorTemperatura with the first element
float menorTemperatura = temperaturas[0]; // Initialize menorTemperatura with the first element

for (int i = 1; i < 12; i++)
{
    if (temperaturas[i] > maiorTemperatura)
        maiorTemperatura = temperaturas[i];
    
    if (temperaturas[i] < menorTemperatura) // Change to < for finding the minimum
        menorTemperatura = temperaturas[i];
}

Console.WriteLine($"A maior temperatura foi {maiorTemperatura}");
Console.WriteLine($"A menor temperatura foi {menorTemperatura}");