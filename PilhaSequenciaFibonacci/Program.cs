using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int posicao;
        Console.WriteLine("Digite a posição desejada na sequência de Fibonacci:");
        posicao = int.Parse(Console.ReadLine());

        if (posicao < 1)
        {
            Console.WriteLine("Por favor, insira uma posição maior ou igual a 1.");
            return;
        }

        PilhaFibonacci pilhaFibonacci = new PilhaFibonacci();
        pilhaFibonacci.ImprimirSequencia(posicao);
    }
}