using System;
using KISS.Clases;

namespace KISS
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("KISS");
            Console.WriteLine("Ingrese los precios de los platos (separados por comas)");
            string input = Console.ReadLine()!;
            string[] preciosSeparados = input.Split(',');
            decimal[] prices = new decimal[preciosSeparados.Length];
            int index = 0;
            foreach (string precio in preciosSeparados)
            {
                if (decimal.TryParse(precio.Trim(), out decimal precios) && precios > 0) {
                    prices[index++] = precios;
                }else {
                    Console.WriteLine("Los valores no válidos serán omitidos");
                }
            }
            Console.WriteLine("Desea agregar una propina personalizada (s/n)");
            string opcion = Console.ReadLine()!.Trim().ToLower();
            decimal tipPercentage = 10;
            if (opcion == "s")
            {
                Console.WriteLine("Ingrese la propina personalizada");
                while (!decimal.TryParse(Console.ReadLine(), out tipPercentage) || tipPercentage < 0)
                {
                    Console.WriteLine("Por favor, ingrese un número válido para la propina:");
                }
            }
            RestaurantBill bill = new RestaurantBill();
            decimal totalBill = bill.CalculateTotal(prices, tipPercentage);
            Console.WriteLine($"Total a pagar (con propina del {tipPercentage}%): {totalBill}");

        }
    }
}