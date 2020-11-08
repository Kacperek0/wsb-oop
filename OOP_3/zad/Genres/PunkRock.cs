using System;
namespace zad
{
    public class PunkRock: Rock
    {
        public int AlcoholPromiles;

        public PunkRock(string artist, string title, string basist, int alcohol_promiles):
            base(artist, title, basist)
        {
            this.AlcoholPromiles = alcohol_promiles;
        }

        public override string Play()
        {
            return base.Play() + $"\nBand has average {AlcoholPromiles} promiles.";
        }
    }
}
