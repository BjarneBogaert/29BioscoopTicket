using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29BioscoopTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            byte leeftijd;
            bool flag= false;

            do
            {
                Console.Write("Wat is uw leeftijd: ");
                leeftijd = byte.Parse(Console.ReadLine());

                if (leeftijd<=5)
                {
                    Console.WriteLine("U moet niks betalen.");
                    flag = true;
                }

                else if (leeftijd <= 12 && leeftijd >= 5)
                {
                    Console.WriteLine($"U moet {13.70 / 2} EUR betalen.");
                    flag = true;
                }

                else if (leeftijd <=54 && leeftijd >=13)
                {
                    Console.WriteLine("u moet 13,70 EUR betalen.");
                    flag = true;
                }

                else
                {
                    Console.WriteLine("U moet niets betalen.");
                    flag = true;
                }

            } while (!flag);
            Console.ReadLine();
            Console.WriteLine("Geniet van uw film!");

            Console.ReadLine();
            Console.WriteLine("Druk op enter om af te sluiten...");
            Console.ReadLine();


        }
    }
}
