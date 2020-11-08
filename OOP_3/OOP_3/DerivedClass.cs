using System;
namespace OOP_3
{
    public class DerivedClass: BaseClass
    {
        public string Surname { get; set; }

        public override void Introduce()
        {
            base.Introduce();
            Console.WriteLine($"My surname is {Surname}");
        }
    }
}
