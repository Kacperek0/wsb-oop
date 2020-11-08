using System;
namespace OOP_3
{
    public class BaseClass
    {
        public string Name { get; set; }

        public virtual void Introduce()
        {
            Console.WriteLine($"My name is {Name}");
        }


    }
}
