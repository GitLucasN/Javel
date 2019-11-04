using System.Collections.Generic;
using Model;

namespace Model
{
    public class Podcast
    {
        public string Url { get; set; }
        public virtual string UppdateringsFrekvens { get; set; }
        public string Kategori { get; set; }
        public string Name { get; set; }
        
        public List<Avsnitt> ListOfAvsnitt = new List<Avsnitt>();
        
        public int AntalAvsnitt { get; set; }

        public Podcast(string url, string uppdateringsFrekvens, string kategori, string name, List<Avsnitt> listOfAvsnitt, int antalAvsnitt)
        {
            Url = url;
            UppdateringsFrekvens = uppdateringsFrekvens;
            Kategori = kategori;
            Name = name;
            ListOfAvsnitt = listOfAvsnitt;
            AntalAvsnitt = antalAvsnitt;

            


        }
        
    }
}
