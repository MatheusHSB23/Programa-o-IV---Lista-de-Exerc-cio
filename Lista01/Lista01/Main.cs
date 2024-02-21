using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nEscolha um exercício para executar:");
            Console.WriteLine("1 - Conversão Cambial de BRL para USD");
            Console.WriteLine("2 - Conversão Cambial de USD para BRL");
            Console.WriteLine("3 - Média de Gasto de Automóvel");
            Console.WriteLine("4 - Cálculo de Idade");
            Console.WriteLine("5 - Calculadora Básica");
            Console.WriteLine("6 - Contagem de Vogais em um Nome");
            Console.WriteLine("7 - Contagem de Consoantes em um Nome");
            Console.WriteLine("8 - Determinação da Faixa Etária");
            Console.WriteLine("9 - Cadastro de Livro");
            Console.WriteLine("10 - Sistema de Cadastro de Alunos");
            Console.WriteLine("0 - Sair");

            Console.Write("Escolha uma opção: ");
            int opcao;

            while (!int.TryParse(Console.ReadLine(), out opcao) || opcao < 0 || opcao > 10)
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
                Console.Write("Escolha uma opção: ");
            }

            switch (opcao)
            {
                case 1:
                    EX01.Run();
                    break;

                case 2:
                    EX02.Run();
                    break;

                case 3:
                    EX03.Run();
                    break;

                case 4:
                    EX04.Run();
                    break;

                case 5:
                    EX05.Run();
                    break;

                case 6:
                    EX06.Run();
                    break;

                case 7:
                    EX07.Run();
                    break;

                case 8:
                    EX08.Run();
                    break;

                case 9:
                    EX09.Run();
                    break;

                case 10:
                    EX10.Run();
                    break;

                case 0:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}
