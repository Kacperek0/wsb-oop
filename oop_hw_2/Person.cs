using System;
namespace oop_hw_2
{
    public class Person
    {
        private string name;
        private string surname;

        public void Introduce()
        {
            Console.WriteLine($"My name is {name} {surname}");
        }
    }
}
