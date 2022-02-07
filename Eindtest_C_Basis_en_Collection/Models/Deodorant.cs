using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindtest_C_Basis_en_Collection.Models
{
    public enum DeoType
    {
        VAPO,
        STICK
    }
    public class Deodorant : Product
    {
        private DeoType _DeoType { get; set; }
        public Deodorant(int productnummer,string merk, string naam, int volume, double prijs,DeoType deoType) : base(productnummer,merk, naam, volume, prijs)
        {
            _DeoType = deoType;
        }
        public override string ToString()
        {
            return$"{base.ToString()} {_DeoType}";
        }
    }
}
