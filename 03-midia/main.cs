using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<double> faturamento = new List<double> { 20.5, 100.0, 0.0, 50.2, 0.0, 30.5, 10.0, 70.0, 0.0, 0.0, 90.5, 40.2, 0.0 };
        List<double> valoresValidos = faturamento.FindAll(valor => valor > 0);

        double menorValor = double.MaxValue, maiorValor = double.MinValue, soma = 0;

        foreach (var valor in valoresValidos)
        {
            soma += valor;
            if (valor < menorValor) menorValor = valor;
            if (valor > maiorValor) maiorValor = valor;
        }

        double media = soma / valoresValidos.Count;
        int diasAcimaMedia = valoresValidos.FindAll(valor => valor > media).Count;

        Console.WriteLine($"Menor valor: {menorValor}");
        Console.WriteLine($"Maior valor: {maiorValor}");
        Console.WriteLine($"Dias com faturamento acima da média: {diasAcimaMedia}");
    }
}