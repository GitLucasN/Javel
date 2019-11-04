using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class KategoriValidator : Validator
    {
        public static bool ValidateKategori(string kategoriInput)
        {
            bool kategoriFinns = false;
            foreach (var k in ListOfKategori.GetKategoriFromJson())
            {
                if (k.Name.ToUpper() == kategoriInput.ToUpper())
                {
                    kategoriFinns = true;
                }
                
            }
            return kategoriFinns;
        }
    }
}