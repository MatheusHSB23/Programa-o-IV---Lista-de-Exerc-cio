using System;

class EX05
{
    public static void Run()
    {
        double num1, num2;

        do
        {
            Console.Write("Digite o primeiro número: ");
        } while (!Double.TryParse(Console.ReadLine().Replace(".", ","), out num1));

        do
        {
            Console.Write("Digite o segundo número: ");
        } while (!Double.TryParse(Console.ReadLine().Replace(".", ","), out num2) || num2 == 0);

        Console.WriteLine($"Soma: {num1 + num2}");
        Console.WriteLine($"Subtração: {num1 - num2}");
        Console.WriteLine($"Multiplicação: {num1 * num2}");
        Console.WriteLine($"Divisão: {num1 / num2}");
        Console.WriteLine($"Resto da divisão: {num1 % num2}");
    }
}
