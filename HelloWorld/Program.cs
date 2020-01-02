using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMessage() + " Varadha");
        }

        public static string GetMessage()
        {
            return "Hello World";
        }
    }
}
