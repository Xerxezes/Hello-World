using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorldClass inmainclass = new HelloWorldClass("hello world");
            inmainclass.consoleout();
            inmainclass.consolein();//To keep the program running. Press enter to exit program.
        }
    }
}
