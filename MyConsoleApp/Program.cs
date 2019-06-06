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
            Person taro = new Person("Taro", 31);
            Person jiro = new Person(30);
            Person ichiro = new Person("ichiro");

            Console.WriteLine(taro.getData());
            Console.WriteLine(jiro.getData());
            Console.WriteLine(ichiro.getData());
            Console.ReadKey();
        }       
    }

    class Person
    {
        public string name;
        public int age;

        public Person()
        {
            this.name = "no name...";
            this.age = 0;
        }

        public Person(string s)
        {
            this.name = s;
            this.age = 0;
        }

        public Person(int n)
        {
            this.name = "no name...";
            this.age = n;
        }

        public Person(string s, int n)
        {
            this.name = s;
            this.age = n;
        }

        public void setData(string s, int n)
        {
            this.name = s;
            this.age = n;
        }

        public string getData()
        {
            string data = this.name + "(" + this.age + ")";
            return data;
        }
    }
}
