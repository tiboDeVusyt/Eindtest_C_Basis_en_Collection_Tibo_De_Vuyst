using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eindtest_C_Basis_en_Collection.Models;

namespace Eindtest_C_Basis_en_Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bestelling bestelling = new Bestelling();
            bestelling.VoegProductToe(new Parfum(1000,"BVLGARI", "BVL", 75, 61.52));
            bestelling.VoegProductToe(new AfterShave(1007,"Cachare", "anias", 50, 24.52,Soort.VAPO));
            bestelling.VoegProductToe(new Deodorant(1008,"DKNY", "Be delisius", 66, 24.52,DeoType.STICK));
            bestelling.VoegProductToe(new AfterShave(1001,"Dolche ", "Light blue", 100, 24.52, Soort.VAPO));
            bestelling.VoegProductToe(new AfterShave(1002,"Georgio armani", "code dona", 50, 24.52, Soort.Gel));
            bestelling.VoegProductToe(new Parfum(1003, "Georgio armani", "code code", 30, 59.32));
            bestelling.VoegProductToe(new Parfum(1004, "Georgio armani", "code cod", 75, 36.84));
            bestelling.VoegProductToe(new Parfum(1005, "Georgio armani", "BVL", 50, 76.00));
            bestelling.VoegProductToe(new Parfum(1006, "Givency", "Pour Elle", 50, 61.52));

            bestelling.ToonLijst();
            Console.WriteLine("de totale prijs is "+ bestelling.TotalePrijs()+"$");
            Console.WriteLine();
            Console.WriteLine("van het merk Georgio armani");
            bestelling.ToonPerMerk("Georgio armani");
            Console.WriteLine();
            Console.WriteLine("alle parfums:");
            bestelling.ToonParfums();
            SchrijfNaarBestand schrijfNaarBestand = new SchrijfNaarBestand();
            schrijfNaarBestand.WriteFile(bestelling.GetProducts());

        }
    }
}
