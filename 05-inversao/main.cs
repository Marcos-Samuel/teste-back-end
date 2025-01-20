using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Informe uma string para inverter:");
        string input = Console.ReadLine();

        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Entrada inválida! Por favor, insira uma string válida.");
            return;
        }

        string inverted = InverterString(input);

        Console.WriteLine("String invertida: " + inverted);
    }

    static string InverterString(string str)
    {
        char[] array = new char[str.Length];
        int j = 0;

        for (int i = str.Length - 1; i >= 0; i--)
        {
            array[j] = str[i];
            j++;
        }

        return new string(array);
    }
}
