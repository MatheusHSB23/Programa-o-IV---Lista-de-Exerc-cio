using System;
using System.Collections.Generic;
using System.Linq;

class Aluno
{
    public string Nome { get; set; }
    public string RA { get; set; }
    public double NotaProva { get; set; }
    public double NotaTrabalho { get; set; }
    public int TotalFaltas { get; set; }

    public double Media => (NotaProva * 7 + NotaTrabalho * 3) / 10;
    public double Frequencia => 1 - (TotalFaltas / 25.0);
    public string Situacao => (Frequencia >= 0.75 && Media >= 7) ? "APROVADO" : "REPROVADO";
}

class EX10
{
    public static void Run()
    {
        List<Aluno> alunos = new List<Aluno>();

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1 - Cadastro de Alunos");
            Console.WriteLine("2 - Cadastro de Notas");
            Console.WriteLine("3 - Cadastro Total de Faltas");
            Console.WriteLine("4 - Relação de Alunos, Notas, Média, Faltas e Situação");
            Console.WriteLine("0 - Sair");

            Console.Write("Escolha uma opção: ");
            int opcao;

            while (!int.TryParse(Console.ReadLine().Replace(".", ","), out opcao) || opcao < 0 || opcao > 4)
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
                Console.Write("Escolha uma opção: ");
            }

            switch (opcao)
            {
                case 1:
                    string nome, ra;

                    do
                    {
                        Console.Write("Nome do aluno: ");
                        nome = Console.ReadLine();
                    } while (string.IsNullOrWhiteSpace(nome) || nome.Any(char.IsDigit));

                    do
                    {
                        Console.Write("RA do aluno (4 dígitos): ");
                        ra = Console.ReadLine();
                    } while (string.IsNullOrWhiteSpace(ra) || ra.Any(c => !char.IsDigit(c)) || ra.Length != 4);

                    alunos.Add(new Aluno { Nome = nome, RA = ra });
                    Console.WriteLine("Aluno cadastrado com sucesso!");
                    break;

                case 2:
                    Console.Write("RA do aluno: ");
                    string raNota;

                    do
                    {
                        raNota = Console.ReadLine();
                    } while (string.IsNullOrWhiteSpace(raNota) || raNota.Any(c => !char.IsDigit(c)) || raNota.Length != 4);

                    Aluno alunoNota = alunos.Find(a => a.RA == raNota);

                    if (alunoNota != null)
                    {
                        double notaProva, notaTrabalho;

                        do
                        {
                            Console.Write("Nota da prova (max 10): ");
                        } while (!double.TryParse(Console.ReadLine().Replace(".", ","), out notaProva) || notaProva < 0 || notaProva > 10);

                        do
                        {
                            Console.Write("Nota do trabalho (max 10): ");
                        } while (!double.TryParse(Console.ReadLine().Replace(".", ","), out notaTrabalho) || notaTrabalho < 0 || notaTrabalho > 10);

                        alunoNota.NotaProva = notaProva;
                        alunoNota.NotaTrabalho = notaTrabalho;

                        Console.WriteLine("Notas cadastradas com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Aluno não encontrado.");
                    }
                    break;

                case 3:
                    Console.Write("RA do aluno: ");
                    string raFalta;

                    do
                    {
                        raFalta = Console.ReadLine();
                    } while (string.IsNullOrWhiteSpace(raFalta) || raFalta.Any(c => !char.IsDigit(c)) || raFalta.Length != 4);

                    Aluno alunoFalta = alunos.Find(a => a.RA == raFalta);

                    if (alunoFalta != null)
                    {
                        int totalFaltas;

                        do
                        {
                            Console.Write("Total de faltas: ");
                        } while (!int.TryParse(Console.ReadLine().Replace(".", ","), out totalFaltas) || totalFaltas < 0);

                        alunoFalta.TotalFaltas = totalFaltas;

                        Console.WriteLine("Faltas cadastradas com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Aluno não encontrado.");
                    }
                    break;

                case 4:
                    foreach (var alunoRelacao in alunos)
                    {
                        Console.WriteLine($"Nome: {alunoRelacao.Nome}, RA: {alunoRelacao.RA}, Nota Prova: {alunoRelacao.NotaProva}, Nota Trabalho: {alunoRelacao.NotaTrabalho}, Média: {alunoRelacao.Media:F2}, Faltas: {alunoRelacao.TotalFaltas}, Frequência: {alunoRelacao.Frequencia:P}, Situação: {alunoRelacao.Situacao}");
                    }
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
