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
            
            PowerPerson jiro = new PowerPerson("Jiro",24,"jiroMail","070-7777-7777","Tokyo,Japan");

            Console.WriteLine(taro.getData());
            Console.WriteLine(jiro.getData());
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

        public virtual string getData()
        {
            string data = this.name + "(" + this.age + ")";
            return data;
        }
    }

    class PowerPerson : Person
    {
        string mail;
        string tel;
        string address;

        public PowerPerson(string name, int age, string mail, string tel, string address)
        {
            this.name = name;
            this.age = age;
            this.mail = mail;
            this.tel = tel;
            this.address = address;
        }

        public override string getData()
        {
            string res = name + "(" + age + ") " + mail + "," + tel + "," + address;
            return res;
        }
    }
}
