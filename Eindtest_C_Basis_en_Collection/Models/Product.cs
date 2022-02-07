using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindtest_C_Basis_en_Collection.Models
{
    public abstract class Product:IComparable<Product>
    {
        public int ProductNummer { get; set; }
        public string Merk { get; set; }
        public string  Naam { get; set; }
        public int Volume { get; set; }
        public double Prijs { get; set; }
        public  Product(int productnummer,string merk, string naam,int volume,double prijs)
        {
            ProductNummer = productnummer;
            Merk =merk;
            Naam =naam;
            Volume =volume;
            Prijs = prijs;
        }

        public int CompareTo(Product other)
        {
            return this.Merk.CompareTo(other.Merk);
        }

        public override string ToString()
        {
            return$"{ProductNummer} Merk:{Merk}               Naam:{Naam}                Volume:{Volume}ml     Prijs: {Prijs}$    Code:{GetProductCode()}";
        }

        public string GetProductCode()
        {
            return $"{Merk.Substring(0,3).ToUpper().Replace(" ","_")}{Naam.Substring(0,3).ToUpper().Replace(" ", "_")}{Volume}";
        }
    }
}
