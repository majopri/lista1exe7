using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1exe7
{
    internal class Program
    {
        static void Main (string[] args)
        {
            const double MilhaMaritmaParaMetro = 1852;

            const double MetroParaQuilometro = 0.001;

            Console.WriteLine("Digite a quantidade de milhas marítmas:");
            double MilhasMaritimas = Convert.ToDouble(Console.ReadLine());

            double quilometros = (MilhasMaritimas *  MilhaMaritmaParaMetro) * MetroParaQuilometro;

            Console.WriteLine($"{MilhasMaritimas} milhas maritimas equivalem a {quilometros} quilometros.");
        }
    }
}
