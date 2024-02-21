using System;

class EX01
{
    public static void Run()
    {
        double valorBRL;

        do
        {
            Console.Write("Informe o valor em BRL: ");
        } while (!Double.TryParse(Console.ReadLine().Replace(".", ","), out valorBRL) || valorBRL < 0);

        double valorUSD = valorBRL * 0.193259;

        Console.WriteLine($"Valor em USD: {valorUSD:F2}");
    }
}