using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person1 = new Person("Nick Portell","53290 Hawald dr");
            Console.WriteLine(person1.ToString());

            Student student1 = new Student("Alien", "Mars", "Interstellar Communications degree", 2121, 10000000);
            Console.WriteLine(student1.ToString());

            Staff Staff1 = new Staff("Space Man","In Space","Space High-School",123123);
            Console.WriteLine(Staff1.ToString());


        }
    }
}
