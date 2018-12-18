using System;

namespace UnitTestRecapAnswers
{
    public class Album
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public int LengthInMinutes { get; set; }
        public int ReleaseYear { get; set; }

        public Album()
        {
            Title = "Default title";
            Artist = "Unknows artist";
            LengthInMinutes = 60;
            ReleaseYear = 1900;
        }

        public Album(string title, string artist, int lengthInMinutes, int releaseYear)
        {
            Title = title;
            Artist = artist;
            LengthInMinutes = lengthInMinutes;
            ReleaseYear = releaseYear;
        }

        public bool IsA21stCenturyAlbum()
        {
            return ReleaseYear >= 2001;
        }

        public void RereleaseAlbum()
        {
            ReleaseYear = DateTime.Now.Year;
        }
    }    
}
