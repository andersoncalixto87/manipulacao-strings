using System;
using System.Globalization;
using System.Text;

namespace manipulando_string
{
    class Program
    {
        static void Main(string[] args)
        {
            const string frase = "And - Anderson de Oliveira Calixto";

            var AndIndexOf = frase.IndexOf("And");
            var AndersonIndexOf = frase.IndexOf("Anderson");
            var OliveiraindexOf = frase.IndexOf("Oliveira");
            var AndStartsWith = frase.StartsWith("And");
            var AndLastIndexOf = frase.LastIndexOf("And");
            var AndContains = frase.Contains("And");
            var oliveiraSubstring = frase.Substring(OliveiraindexOf,8);
            Console.WriteLine("");
            Console.WriteLine($"Índice de primeira ocorrência de And: {AndIndexOf}");
            Console.WriteLine($"Índice de primeira ocorrência de Anderson: {AndersonIndexOf}");
            Console.WriteLine($"Índice de primeira ocorrência de Oliveira: {OliveiraindexOf}");
            Console.WriteLine($"Índice de última ocorrência de And: {AndLastIndexOf}");
            Console.WriteLine($"String começa com And: {AndStartsWith}");
            Console.WriteLine($"String contém And: {AndContains}");
            Console.WriteLine($"Substring de Oliveira: {oliveiraSubstring}");
            Console.WriteLine("");
            Console.WriteLine("----- StringBuilder -----");

            var nomes = new string[] { "Anderson", "Felipe", "João", "Pedro", "Lucas", "Daniel" };
            var stringBuilder = new StringBuilder();

            foreach (var nome in nomes)
            {
                stringBuilder.AppendLine($"Seja bem-vindo {nome}");
            }

            Console.WriteLine(stringBuilder);

            double preco = 14.99;
            var now = DateTime.Now;
            
            var precoFormatadoLibra = preco.ToString("C", new CultureInfo("en-GB", false));
            var precoFormatadoDolar = preco.ToString("C", new CultureInfo("en-US", false));
            var precoFormatadoCulturaLocal = preco.ToString("C", CultureInfo.CurrentCulture);

            
            Console.WriteLine("----- Formatação de moeda -----");

            Console.WriteLine($"Preço (em libras): {precoFormatadoLibra}");
            Console.WriteLine($"Preço (em dólares): {precoFormatadoDolar}");
            Console.WriteLine($"Preço (em  moeda local): {precoFormatadoCulturaLocal}");

            Console.WriteLine("----- Formatação de data -----");

            Console.WriteLine("----- Usando string.Format -----");
            var dataStringFormat = string.Format("Data longa: {0:D}, Data Curta: {1:d}, Moeda: {2:C}\n", now, now, preco);
            Console.WriteLine(dataStringFormat);


            Console.WriteLine("----- Usando sobrecargas de ToString -----");

            var dataFormatadaLonga = now.ToString("D"); // equivalente a now.ToLongDateString();
            var dataFormatadaCurta = now.ToString("d"); // equivalente a now.ToShortDateString();
            var dataFormatadaPersonalizada = now.ToString("dd-MM-yyyy");

            Console.WriteLine($"Data em formato longo: {dataFormatadaLonga}");
            Console.WriteLine($"Data em formato curto: {dataFormatadaCurta}");
            Console.WriteLine($"Data em formato dd-MM-yyyy: {dataFormatadaPersonalizada}\n");

            Console.WriteLine("----- Usando interpolação de string -----");

            Console.WriteLine($"Data longa: {now:D}, Data curta: {now:d}, Moeda: {preco:C}");
            

            Console.ReadLine();
        }
    }
}
