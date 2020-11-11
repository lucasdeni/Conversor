using System;

namespace Conversor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é Cotação do Dólar? "); // Entrada do usuário para a cotação do dólar
            Conversor.cotacao = double.Parse(Console.ReadLine());

            Console.Write("Quantos Dólares Você Vai Comprar? "); // Entrada do usuário para a quantidade em dólar
            Conversor.valorCompra = double.Parse(Console.ReadLine());
         
            Console.Write("Valor a Ser Pago em Reais: " + Conversor.ValorReais().ToString("F2", CultureInfo.InvariantCulture)); // Escrever valor em reais

            Console.ReadKey();
        }
    }
}
