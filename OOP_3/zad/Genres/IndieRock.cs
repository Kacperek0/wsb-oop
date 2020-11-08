using System;
namespace zad
{
    public class IndieRock: Rock
    {
        public string Keyboard;

        public IndieRock(string name, string surname, string basist, string keyboard): base(name, surname, basist)
        {
            this.Keyboard = keyboard;
        }

        public override string Play()
        {
            return base.Play() + $"\nKeyboard player is {Keyboard}";
        }
    }
}
