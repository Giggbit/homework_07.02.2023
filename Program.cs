using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Классы_в.NET_homework_07._02._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Web web = new Web();
            //web.Enter();
            web.Ip = "127.0.0.1";
            web.Print();

            Magazine mag = new Magazine();
            mag.Name = "test";
            mag.Year = "1928";
            mag.Print();

            Shop sh = new Shop();
            sh.Adress = "qwerty 123";
            sh.Name = "test";
            sh.Print();
        }
    }
}
