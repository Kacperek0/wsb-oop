using System;
namespace OOP_lab1
{
    public class Human
    {
        public string name = "NONE";
        public string surname = "NONE";

        public Human(string ctorName)
        {
            name = ctorName;
        }

        public Human(string ctorName, string ctorSurname)
        {
            name = ctorName;
            surname = ctorSurname;
        }

        public void Introduce()
        {
            Console.WriteLine("Mam na imie " + this.name);
        }

    }
}
