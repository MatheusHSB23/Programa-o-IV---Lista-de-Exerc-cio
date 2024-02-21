using System;

struct Livro
{
    public string Titulo;
    public string Autor;
    public double Valor;

    public override string ToString()
    {
        return $"Título: {Titulo}, Autor: {Autor}, Valor: {Valor:C}";
    }
}

class EX09
{
    public static void Run()
    {
        Livro livro;

        do
        {
            Console.Write("Informe o título do livro: ");
            livro.Titulo = Console.ReadLine();
        } while (string.IsNullOrWhiteSpace(livro.Titulo) || livro.Titulo.Any(char.IsDigit));

        do
        {
            Console.Write("Informe o autor do livro: ");
            livro.Autor = Console.ReadLine();
        } while (string.IsNullOrWhiteSpace(livro.Autor) || livro.Autor.Any(char.IsDigit));

        do
        {
            Console.Write("Informe o valor do livro: ");
        } while (!double.TryParse(Console.ReadLine(), out livro.Valor) || livro.Valor < 0);

        Console.WriteLine(livro.ToString());
    }
}
