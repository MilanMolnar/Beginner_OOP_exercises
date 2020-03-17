using System;

namespace _17_ObjectMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("jim", "Business", 2.8);
            Student student2 = new Student("joe", "Art", 3.8);

            Console.WriteLine(student1.name + " : " + student1.HasHonors());
            Console.WriteLine(student2.name + " : " + student2.HasHonors());
        }
    }
}
