using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person taro = new Person("Taro", 30);
            Person hanako = new Person("Hanako", 20);

            PersonUility.person = taro;
            PersonUility.print();
            PersonUility.person = hanako;
            PersonUility.print();

            Console.ReadKey();
        }       
    }

    class Person
    {
        internal string name;
        internal int age;

        public Person()
        {
            name = "no name...";
            age = 0;
        }

        public Person(string s, int n)
        {
            name = s;
            age = n;
        }

        public string getData()
        {
            string data = this.name + "(" + this.age + ")";
            return data;
        }
    }

    static class PersonUility
    {
        public static Person person;

        public static void print()
        {
            if(person == null)
            {
                return;
            }
            string data = person.getData();
            Console.WriteLine("****** Printed by personUtility *******");
            Console.WriteLine(data);
            Console.WriteLine("****** end ******");
        }
    }
}
