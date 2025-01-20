using System;

class Program
{
    static void Main()
    {
        Console.Write("Informe um número para verificar: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int numero))
        {
            if (IsFibonacci(numero))
            {
                Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine($"O número {numero} NÃO pertence à sequência de Fibonacci.");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida! Por favor, insira um número inteiro.");
        }
    }

    static bool IsFibonacci(int num)
    {
        int a = 0, b = 1, temp;

        while (b <= num)
        {
            if (b == num)
                return true;

            temp = a + b;
            a = b;
            b = temp;
        }
        return false;
    }
}