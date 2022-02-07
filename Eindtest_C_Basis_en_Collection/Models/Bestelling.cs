using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eindtest_C_Basis_en_Collection.Interfaces;

namespace Eindtest_C_Basis_en_Collection.Models
{
    public class Bestelling:IBerekenbaar
    {
        public double TotPrijs { get; set; }
        public List<Product> Products = new List<Product>();
        public void VoegProductToe(Product product)
        {
            Products.Add(product);
            
        }
        public void ToonLijst()
        {
            foreach (var item in Products)
            {
                Console.WriteLine(item);
            }
        }
        public void ToonPerMerk(string merk)
        {
            foreach (var item in Products)
            {
                if (item.Merk == merk)
                {
                    Console.WriteLine(item);
                }
            }
        }
        public void ToonParfums()
        {
            foreach (var item in Products)
            {
                if (item.GetType() == typeof(Parfum))
                {
                    Console.WriteLine(item);
                }
            }
        }

        public double TotalePrijs()
        {
            foreach (var item in Products)
            {
                TotPrijs += item.Prijs;
            }
            return TotPrijs;
        }
        public List<Product> GetProducts()
        {
            return Products; 
        }
    }
}
