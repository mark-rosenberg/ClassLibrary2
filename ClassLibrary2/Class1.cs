using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Class1
    {
        public string Count(int arg)
        {
            string results = "";
            for (int i = 1; i <= arg; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    results += "Fizz Buzz";
                    results += "\r\n";

                }
                else if (i % 3 == 0)
                {
                    results += "Fizz";
                    results += "\r\n";
                }
                else if (i % 5 == 0)
                {
                    results += "Buzz";
                    results += "\r\n";
                }
                else
                {
                    results += i.ToString();
                    results += "\r\n";

                }

            }
            return results;

        }
    }
}
