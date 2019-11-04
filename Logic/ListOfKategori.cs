using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Model;

namespace Logic
{
    public class ListOfKategori
    {
        public static List<Kategori> Kategorier = new List<Kategori>();
        public static Serializer _serializer = new Serializer();

        public static void AddToListOfKategori(Kategori kategori) {
            List<Kategori> kategorier = GetKategoriFromJson();

            if(kategorier != null)
            {
                Kategorier = kategorier;
            }

            Kategorier.Add(kategori);
            Serializer.SerializeKategoriToJson(Kategorier);
        }
        public static List<Kategori> GetKategoriFromJson()
        {
            List<Kategori> kategorier = Serializer.DeserializeKategoriJson();
            return kategorier;
            
        }
    }
}
