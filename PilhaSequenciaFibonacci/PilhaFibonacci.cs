class PilhaFibonacci
{
    public void ImprimirSequencia(int posicao)
    {
        Stack<int> pilha = new Stack<int>();
        pilha.Push(0);
        pilha.Push(1);

        Console.WriteLine("Sequência de Fibonacci até a posição " + posicao + ":");

        if (posicao >= 1) Console.WriteLine(0);
        if (posicao >= 2) Console.WriteLine(1);

        int count = 2;
        while (count < posicao)
        {
            int penultimo = pilha.Pop();
            int ultimo = pilha.Pop();
            int atual = penultimo + ultimo;
            pilha.Push(ultimo);
            pilha.Push(atual);
            Console.WriteLine(atual);
            count++;
        }
    }
}