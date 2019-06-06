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
            Person taro = new Person();
            taro.name = "";
            taro.age = -20;

            Person jiro = new Person();
            jiro.name = "Jiro";
            jiro.age = 30;

            Console.WriteLine(taro.getData());
            Console.WriteLine(jiro.getData());
            Console.ReadKey();
        }       
    }

    class Person
    {
        private string myname;

        public string name
        {
            get { return myname; }
            set
            {
                if(value != "") { myname = value; }
                else { myname = "noname..."; }
            }
        }

        private int old;

        public int age
        {
            get { return old; }
            set
            {
                if(value < 0) { old = 0; }
                else { old = value; }
            }
        }

        public Person()
        {
            myname = "no name...";
            old = 0;
        }

        public string getData()
        {
            string data = this.name + "(" + this.age + ")";
            return data;
        }
    }
}
