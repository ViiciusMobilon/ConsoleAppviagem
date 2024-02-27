using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppviagem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Qual a distancia precorrida na viagem");
            double d = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor do litro de conbustivel");
            double pl = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual o consumo de seu veiculo");
            double comsumo = double.Parse(Console.ReadLine());

            double resultado1 = d / comsumo;

            double resultado2 = pl * resultado1;



            Console.WriteLine("o gato total com a viagem foi de:" + resultado2);
            Console.ReadKey();


        }
    }
}
