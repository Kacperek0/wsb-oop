using System;
namespace zad
{
    public class Song
    {
        public string Artist;
        public string Title;

        public Song(string artist, string title)
        {
            this.Artist = artist;
            this.Title = title;
        }

        public virtual string Play()
        {
            return $"Artist: {Artist}, Title: {Title}";
        }

    }
}
