using System;

namespace OOP_3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Person p1 = new Person("Kacper", "Szczepanek");
            Person p2 = new Student("Maciej", "Cegła", 8979846);
            Student s2 = new Student("Wojciech", "Szalony", 998745);

            //Console.WriteLine(p1.ToString());
            //Console.WriteLine(p2.ToString());
            //Console.WriteLine(s2.ToString());

            Person[] people = new Person[3];
            people[0] = p1;
            people[1] = p2;
            people[2] = s2;

            foreach (var per in people)
            {
                Console.WriteLine(per.ToString());
            }
        }
    }
}
