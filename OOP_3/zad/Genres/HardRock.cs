using System;
namespace zad
{
    public class HardRock: Rock
    {
        public string LeadGuitarrist;

        public HardRock(string artist, string title, string basist, string lead_guitarrist):
            base(artist, title, basist) 
        {
            this.LeadGuitarrist = lead_guitarrist;
        }

        public override string Play()
        {
            return base.Play() + $"\nLead Guitarrist: {LeadGuitarrist}";
        }
    }
}
