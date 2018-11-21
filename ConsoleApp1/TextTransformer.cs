using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TextTransformer
    {
        public List<string> Str = new List<string>();

        public TextTransformer(string str)
        {
            Str.Add(str);
        }

        public TextTransformer() { }

        public void Add(string item)
        {
            Str.Add(item);
        }

        public IEnumerator GetEnumerator()
        {
            foreach (string s in Str)
            {
                if (s != null)
                    yield return s.ToUpper();
                else
                    yield return "Empty string!";
            }
        }

    }
}
