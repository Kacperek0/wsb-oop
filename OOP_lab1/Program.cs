using System;

namespace OOP_lab1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Human h1 = new Human("Marek", "Cegła");
            Console.WriteLine("Hello " + h1.name);
            h1.name = "Maciej";
            Console.WriteLine(h1.name);
            h1.Introduce();
        }


    }

   
}
