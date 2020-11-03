using System;

namespace OOP_homework
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.SetData("Kacper", "Szczepanek");
            p1.Introduce();

            Console.WriteLine(p1.Name);
            //p1.Name = "Kuba";
            //Console.WriteLine(p1.Name);
        }
    }
}
