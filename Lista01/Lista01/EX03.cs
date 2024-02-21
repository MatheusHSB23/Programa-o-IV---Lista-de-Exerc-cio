using System;

class EX03
{
    public static void Run()
    {
        double distancia, combustivel;

        do
        {
            Console.Write("Informe a distância total em KM: ");
        } while (!Double.TryParse(Console.ReadLine().Replace(".", ","), out distancia) || distancia < 0);

        do
        {
            Console.Write("Informe o gasto de combustível em Lts: ");
        } while (!Double.TryParse(Console.ReadLine().Replace(".", ","), out combustivel) || combustivel < 0);

        double mediaGasto = distancia / combustivel;

        Console.WriteLine($"Média de gasto: {mediaGasto:F2} KM/L");
    }
}
