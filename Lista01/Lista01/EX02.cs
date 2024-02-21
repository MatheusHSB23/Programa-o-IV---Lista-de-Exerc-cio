using System;

class EX02
{
    public static void Run()
    {
        double valorUSD;

        do
        {
            Console.Write("Informe o valor em USD: ");
        } while (!Double.TryParse(Console.ReadLine().Replace(".", ","), out valorUSD) || valorUSD < 0);

        double valorBRL = valorUSD * 5.22;

        Console.WriteLine($"Valor em BRL: {valorBRL:F2}");
    }
}