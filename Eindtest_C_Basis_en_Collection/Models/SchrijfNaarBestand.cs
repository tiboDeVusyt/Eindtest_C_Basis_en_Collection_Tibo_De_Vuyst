using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Eindtest_C_Basis_en_Collection.Models
{
    public class SchrijfNaarBestand
    {
        public string FileDirectory = "C:/intec/Bestelingen.txt";
        public void WriteFile(List<Product> list)
        {
            Bestelling bestelling = new Bestelling();
            using (StreamWriter stream = new StreamWriter(FileDirectory,false))
            {
                foreach (var item in list)
                {
                    stream.WriteLine(item);
                }
            }
        }
    }
}
