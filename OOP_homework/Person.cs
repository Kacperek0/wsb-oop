using System;
namespace OOP_homework
{
    public class Person
    {
        string name, surname, address;
        Address a1 = new Address();

        public string Address
        {
            get;
            set;
        }

        public Person()
        {
            
        }

        public void Introduce()
        {
            Console.WriteLine("Hi! My name is {0} {1}", this.name, this.surname);
        }

        public void SetData(string name, string surname)
        {
            this.name = name;
            this.surname = surname;

        }




    }
}
