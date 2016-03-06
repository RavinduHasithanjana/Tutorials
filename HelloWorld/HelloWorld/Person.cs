using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Person
    {
        String name;
        public String getName()
        {
            return name;
        }

        public void setName(String _name)
        {
            name = _name;
        }

        public void execution()
        {
            String personname;
            Console.WriteLine("Please enter your name");
            personname = Console.ReadLine();
            Person p = new Person();
            p.setName(personname);

            Console.WriteLine("Hi"+" "+p.getName());
            Console.ReadLine();

        }

       
    }
}
