using System;
namespace zad
{
    public class Rock: Song
    {
        public string Basist;

        public Rock(string name, string surname, string basist): base(name, surname)
        {
            this.Basist = basist;
        }

        public override string Play()
        {
            return base.Play() + $"\nBasist name: {Basist}";
        }
    }
}
