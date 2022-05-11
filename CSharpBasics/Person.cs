using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        private byte Age;
        private float Height;
        private byte Weight;

        public void Introduce()
        {
            Console.WriteLine($"My name is, {FirstName} {LastName}");
        }
               
        public void Walk()
        {
        }

        public void Talk()
        {
        }

        public void Eat()
        {
        }

        public void Sleep()
        {
        }
    }
}
