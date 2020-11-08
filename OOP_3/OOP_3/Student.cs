using System;
namespace OOP_3
{
    public class Student: Person
    {
        public int IndexNo { get; set; }
        

        public Student(string name, string surname, int indexno): base(name, surname)
        {
            this.IndexNo = indexno;
        }

        public override string ToString()
        {
            return base.ToString() + $" [{IndexNo}]";
        }
    }
}
