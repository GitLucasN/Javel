using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using Data;
using Model;

namespace Logic
{
    public class EntityCreater : ICreater
    {
        //Skapar en podcast och lägger till den i listan
        public static bool CreatePodcast(string url, string uppdateringsFrekvens, string kategori, string namn)
        {
            List<Avsnitt> listOfAvsnitt = new List<Avsnitt>();
            int antalAvsnitt = 0;
            //Loop count TODO

            List<SyndicationItem> avsnittList = Serializer.DeserializeRSS<SyndicationItem>(url);
            foreach (var a in avsnittList)
            {
                antalAvsnitt++;
                string title = a.Title.Text;
                string subject = a.Summary.Text;
                var avsnitt = new Avsnitt(title, subject, url);
                listOfAvsnitt.Add(avsnitt);
            }
            if (antalAvsnitt != 0)
            {
                var p = new Podcast(url, uppdateringsFrekvens, kategori, namn, listOfAvsnitt, antalAvsnitt);
                //lägger till den skapade podcasten i en lista
                ListOfPodcast.AddToListOfPodcast(p);
                return true;
            }
            else
            {
                return false;
            }



        }



        public static void CreateAvsnitt()
        {

        }
        public  void CreatePodcastList()
        {
            
        }

        public static void CreateKategori(string name)
        {
            Kategori k = new Kategori(name);
            ListOfKategori.AddToListOfKategori(k);

        }
    }
}
