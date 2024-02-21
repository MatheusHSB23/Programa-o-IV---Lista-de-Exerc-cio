using System;

class EX06
{
    public static void Run()
    {
        string nome;

        //do
        {
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine().ToLower();
        } while (string.IsNullOrWhiteSpace(nome) || nome.Any(char.IsDigit) || !nome.All(char.IsLetter)) ;

        int countVogais = 0;

        foreach (char letra in nome)
        {
            if ("aeiou".Contains(letra))
                countVogais++;
        }

        Console.WriteLine($"Quantidade de vogais: {countVogais}");
    }
}
