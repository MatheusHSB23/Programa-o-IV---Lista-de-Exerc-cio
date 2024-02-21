using System;

class EX04
{
    public static void Run()
    {
        int anoNascimento;

        do
        {
            Console.Write("Informe o ano de nascimento: ");
        } while (!Int32.TryParse(Console.ReadLine(), out anoNascimento) || anoNascimento < 0 || anoNascimento > DateTime.Now.Year);

        int idade = DateTime.Now.Year - anoNascimento;

        Console.WriteLine($"Idade: {idade} anos");
    }
}
