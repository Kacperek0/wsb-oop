using System;
namespace zad
{
    public class GrungeRock: Rock
    {
        public string Drummer;

        public GrungeRock(string name, string surname, string basist, string drummer):
            base(name, surname, basist)
        {
            this.Drummer = drummer;
        }

        public override string Play()
        {
            return base.Play() + $"\nDrummer name: {Drummer}";
        }
    }
}
