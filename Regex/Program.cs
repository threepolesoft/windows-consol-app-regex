using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexTu
{
    class Program
    {
        static void Main(string[] args)
        {



            string input = "Course fee (400)";

            string output= "";
            //output= Regex.Replace(input, @"[\d-]", string.Empty);

            output = Regex.Replace(input, "[A-Za-z ()]", string.Empty);

            Console.WriteLine(output);

            Console.ReadLine();

        }
    }
}
