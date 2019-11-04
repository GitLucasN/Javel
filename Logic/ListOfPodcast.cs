using System.Collections.Generic;
using Data;
using Model;
namespace Logic
{
    public class ListOfPodcast
    {
        
        public static List<Podcast> Podcasts = new List<Podcast>();
        public static Serializer _serializer = new Serializer();
        
        public ListOfPodcast()
        {

        }

        public static void AddToListOfPodcast(Podcast podcast)
        {
            List<Podcast> podcasts = GetPodcastFromJson();

            if(podcasts != null){
            Podcasts = podcasts;
            }
            Podcasts.Add(podcast);
            Serializer.SerializeToJson(Podcasts);
        }
        
        public static List<Podcast> GetPodcastFromJson()
        {
            List<Podcast> listOfPodcast = Serializer.DeserializePodcastJson();
            return listOfPodcast;
        }
        public static List<Podcast> GetPodcastFromJsonKategori(string kategori)
        {
            List<Podcast> listOfPodcast = Serializer.DeserializePodcastJson(kategori);
            return listOfPodcast;
        }
        public static void DeleteFromListofPodcast(string url)
        {
            List<Podcast> podcasts = GetPodcastFromJson();
            if (podcasts != null && Serializer.CheckIfPodcastExsists(url))
            {
                Serializer.DeletePodcastFromJson(url);

               
            }
            
        }
        
    }
}