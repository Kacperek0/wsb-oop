using System;
namespace OOP_homework
{
    public class Person
    {
        string Name;
        string Surname;

        public Person()
        {
            
        }

        public void Introduce()
        {
            Console.WriteLine("Hi! My name is {0} {1}", this.Name, this.Surname);
        }

        public void SetData(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;

        }
    }
}
