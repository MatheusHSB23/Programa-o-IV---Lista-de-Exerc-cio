using System;

class EX07
{
    public static void Run()
    {
        string nome;

        do
        {
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine().ToLower();
        } while (string.IsNullOrWhiteSpace(nome) || nome.Any(char.IsDigit) || !nome.All(char.IsLetter));

        int countConsoantes = 0;

        foreach (char letra in nome)
        {
            if ("bcdfghjklmnpqrstvwxyz".Contains(letra))
                countConsoantes++;
        }

        Console.WriteLine($"Quantidade de consoantes: {countConsoantes}");
    }
}

