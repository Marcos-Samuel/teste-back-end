using System;
using System.IO;
using System.Linq;
using Newtonsoft.Json.Linq;

class Program
{
    static void Main()
    {
        string jsonPath = "faturamento.json"; 
        string jsonData = File.ReadAllText(jsonPath);

        var faturamento = JArray.Parse(jsonData)
            .Where(dia => dia["valor"].Type == JTokenType.Float)
            .Select(dia => dia["valor"].Value<decimal>())
            .ToList();

        if (faturamento.Count == 0)
        {
            Console.WriteLine("Nenhum dado de faturamento disponível.");
            return;
        }

        decimal menorFaturamento = faturamento.Min();
        decimal maiorFaturamento = faturamento.Max();
        decimal mediaMensal = faturamento.Average();

        int diasAcimaDaMedia = faturamento.Count(valor => valor > mediaMensal);

        Console.WriteLine($"Menor faturamento do mês: R${menorFaturamento:F2}");
        Console.WriteLine($"Maior faturamento do mês: R${maiorFaturamento:F2}");
        Console.WriteLine($"Dias com faturamento acima da média: {diasAcimaDaMedia}");
    }
}
