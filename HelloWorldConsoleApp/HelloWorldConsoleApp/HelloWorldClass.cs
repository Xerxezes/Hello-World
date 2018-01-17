using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldConsoleApp
{
    class HelloWorldClass
    {
        string message;
        public HelloWorldClass(string msg)
        {
            message = msg;
        }
        public void consoleout()
        {
            Console.WriteLine(message);
        }
        public void consolein()
        {
            Console.ReadLine();
        }
    }
}
