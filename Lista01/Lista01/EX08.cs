using System;

class EX08
{
    public static void Run()
    {
        string nome;
        int anoNascimento;

        do
        {
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
        } while (string.IsNullOrWhiteSpace(nome) || nome.Any(char.IsDigit));

        do
        {
            Console.Write("Digite o ano de nascimento: ");
        } while (!int.TryParse(Console.ReadLine(), out anoNascimento) || anoNascimento < 0 || anoNascimento > DateTime.Now.Year);

        int idade = DateTime.Now.Year - anoNascimento;

        string faixaEtaria;

        if (idade <= 19)
            faixaEtaria = "Jovem";
        else if (idade <= 59)
            faixaEtaria = "Adulto";
        else
            faixaEtaria = "Idoso";

        Console.WriteLine($"Faixa etária: {faixaEtaria}");
    }
}
