using System;

class Program
{
    static void Main()
    {
        int INDICE = 13, SOMA = 0, K = 0;

        while (K < INDICE)
        {
            K += 1;
            SOMA += K;
        }

        Console.WriteLine($"O valor de SOMA é: {SOMA}");
    }
}
