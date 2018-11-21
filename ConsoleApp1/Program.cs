using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string Str = "my string";
            string Str1 = null;
            TextTransformer text = new TextTransformer();
            text.Add(Str);
            text.Add(Str1);

            foreach (var s in text)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}
