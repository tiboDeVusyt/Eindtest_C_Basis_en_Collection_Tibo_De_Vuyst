using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindtest_C_Basis_en_Collection.Models
{
    public class Parfum:Product
    {
        public Parfum(int productnummer, string merk, string naam, int volume, double prijs) : base(productnummer, merk, naam, volume, prijs)
        {
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
