using System;

namespace oop_hw_2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var person = new Person("Kacper", "Szczepanek");
            person.Introduce();

            var person1 = new Person();
            person1.SetData("Elisabeth", "Brick");
            person1.Introduce();

            var address1 = new Address();
            address1.SetAddress("Major", 4, "00-001", "Warsaw", "Poland");
            address1.GetAddress();

            var address2 = new Address();
            address2.SetAddress("Minor", 8, 10, "22-100", "Cracow", "Poland");
            address2.GetAddress();

            var person3 = new Person();
            person3.SetData("Bloody", "Marry", "Scary", 10, "66-666", "Scaryhill", "Scaryland");
            person3.Introduce();
        }
    }
}
