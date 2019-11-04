namespace Model
{
    public class Avsnitt
    {
        public string Title { get; set; }
        public string Subject { get; set; }
        
        public string Podcast { get; set; }

        public Avsnitt(string title, string subject,string podcast)
        {
            Title = title;
            Subject = subject;
            Podcast = podcast;
        }

    }
}
