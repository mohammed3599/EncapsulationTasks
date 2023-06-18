using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Encapsulation_Practise
{
    public class Person
    {
        public string name { get; set; }
        public int age { get; set; }
        public string address { get; set; }

        public void setPerson(string name, int age, string address)
        {
            this.name = name;
            this.age = age;
            this.address = address;
        }

        public void getPerson()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Address: " + address);
        }
    }
}
