using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindtest_C_Basis_en_Collection.Models
{
    public enum Soort
    {
        VAPO,
        Gel,
    }
    public class AfterShave : Product
    {
        private Soort _Soort { get; set; }

        public AfterShave(int productnummer,string merk, string naam, int volume, double prijs,Soort soort ) : base(productnummer,merk, naam, volume, prijs)
        {
            _Soort = soort;
        }
        public override string ToString()
        {
            return $"{base.ToString()}  {_Soort}";
        }
    }
}
