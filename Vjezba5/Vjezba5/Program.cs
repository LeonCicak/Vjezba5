using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite cijenu bez PDV-a: ");
            decimal cijenaBezPDV = decimal.Parse(Console.ReadLine());

            Console.Write("Unesite cijenu s PDV-om: ");
            decimal cijenaSPDV = decimal.Parse(Console.ReadLine());

            if (cijenaSPDV > cijenaBezPDV)
            {
                decimal pdv = cijenaSPDV - cijenaBezPDV;
                decimal pdvPostotak = (pdv / cijenaBezPDV) * 100;

                Console.WriteLine($"Iznos PDV-a je: {pdv}");
                Console.WriteLine($"Postotak PDV-a je: {pdvPostotak}%");
            }
            else
            {
                Console.WriteLine("Cijena s PDV-om mora biti veća od cijene bez PDV-a.");
            }
        }
    }
}
