using ConferenciaDsv.Models; // Namespace contendo a classe Cubagem
using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        // Instância da classe Cubagem
        Cubagem cubagem = new Cubagem();
        Colaborador colaborador = new Colaborador();

        // Lista para armazenar as caixas
        var caixas = new List<(double Altura, double Largura, double Profundidade)>();

        Console.WriteLine("Digite o nome do colaborador:");
         string NomeColabodador  = Console.ReadLine();

        // Entrada do usuário
        Console.WriteLine("Quantas caixas você deseja calcular?");
        int quantidadeCaixas = int.Parse(Console.ReadLine());

        for (int i = 1; i <= quantidadeCaixas; i++)
        {
            Console.WriteLine($"Insira as dimensões da caixa {i}:");

            Console.Write("Altura: ");
            double altura = double.Parse(Console.ReadLine());

            Console.Write("Largura: ");
            double largura = double.Parse(Console.ReadLine());

            Console.Write("Profundidade: ");
            double profundidade = double.Parse(Console.ReadLine());

            // Adiciona a caixa na lista
            caixas.Add((altura, largura, profundidade));
        }

        // Calcula o volume total
        double volumeTotal = cubagem.CalcularVolumeTotal(caixas);

        // Exibe o resultado
        Console.WriteLine(value: $"Colaborador {colaborador} : {volumeTotal} m³");
    }
}

