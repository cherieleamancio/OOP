using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMANCIO_CaO
{
    internal class Person
    {
        public string name;
        public int age;
        public string gender;

        public void Greet()
        {
            Console.WriteLine(" Magandang Buhay! I am " + name +" "+ age + " years old and I am a " + gender);
        }
    }
}
