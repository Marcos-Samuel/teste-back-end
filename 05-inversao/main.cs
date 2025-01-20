using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma string: ");
        string input = Console.ReadLine();
        string reversed = ReverseString(input);

        Console.WriteLine($"String invertida: {reversed}");
    }

    static string ReverseString(string str)
    {
        char[] reversed = new char[str.Length];
        for (int i = 0, j = str.Length - 1; i < str.Length; i++, j--)
        {
            reversed[i] = str[j];
        }
        return new string(reversed);
    }
}