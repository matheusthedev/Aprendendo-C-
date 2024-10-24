int totalHomens = 0;
      int  totalMulheres = 0,;
        int somaIdadeHomens = 0;
         int somaIdadeMulheres = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Entrevistando a pessoa {i + 1}:");

            Console.Write("Digite a idade da pessoa: ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Digite o peso da pessoa: ");
            float peso = float.Parse(Console.ReadLine());

            Console.Write("Digite o sexo da pessoa (M para masculino, F para feminino): ");
            string sexo = Console.ReadLine().ToUpper();

            if (sexo == "M")
            {
                totalHomens++;
                somaIdadeHomens += idade;
            }
            else if (sexo == "F")
            {
                totalMulheres++;
                somaIdadeMulheres += idade;
            }
        }

        float mediaIdadeHomens = totalHomens > 0 ? (float)somaIdadeHomens / totalHomens : 0;
        float mediaIdadeMulheres = totalMulheres > 0 ? (float)somaIdadeMulheres / totalMulheres : 0;

        Console.WriteLine("\nResultados:");
        Console.WriteLine($"Total de Homens: {totalHomens}");
        Console.WriteLine($"Total de Mulheres: {totalMulheres}");
        Console.WriteLine($"Média de idade dos Homens: {mediaIdadeHomens:F2}");
        Console.WriteLine($"Média de idade das Mulheres: {mediaIdadeMulheres:F2}");
    