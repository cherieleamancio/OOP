using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMANCIO_CaO
{
    class Program
    {
        static void Main(string[] args )
        {
            Person person1 = new Person();

            person1.name = " CHERIELE";
            person1.age = 19;
            person1.gender = "FEMALE";

            person1.Greet();
            Console.ReadKey();

        }
    }
}
