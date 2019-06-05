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
            Console.WriteLine(taro.getData());
            Console.ReadKey();
        }       
    }

    class Person
    {
        public string name;
        public int age;

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
