using System.Data.SqlTypes;
using System;
using System.Collections.Generic;
using System.Globalization;
using Entity;

namespace ExercicioTaxPayer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Entre com o numero de taxas:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++){
                Console.WriteLine($"Tax payer #{i} data");
                Console.WriteLine("Individual ou Company (i/c)? ");
                char type = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                String name = Console.ReadLine();
                Console.Write("Rendimentos: ");
                double rendimentos = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                if( type == 'i'){
                    Console.Write("Gastos em Saude: ");
                    double helthExpe = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Individual(name, rendimentos, helthExpe));
                }else if( type == 'c'){
                    Console.Write("Numero de empregados: ");
                    int numeroEmpre = int.Parse(Console.ReadLine());

                    list.Add(new Company(name, rendimentos, numeroEmpre));
                }else{
                     Console.Write("Tipo não existente: ");                     
                }
            }

            double soma = 0.0;
            Console.WriteLine();//pula uma linha
            Console.WriteLine("Valor das taxas");
            foreach (TaxPayer item in list)
            {
                double tax = item.Tax();
                Console.WriteLine(item.Nome + ": $" + tax.ToString("F2", CultureInfo.InvariantCulture)); // "F2" indica duas casas descimais
                soma += tax;
            }

            Console.WriteLine();
            Console.WriteLine("Total taxas: $ " + soma.ToString("F2", CultureInfo.InvariantCulture));           
        }
    }
}
