using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int int1 = 13;
            double dbl1 = 3000000000000;
            string text = "10";
            int1 = Convert.ToInt32(text);
            int1 = Convert.ToInt32(dbl1);
            dbl1 = Convert.ToDouble(text);
            dbl1 = Convert.ToDouble(int1);
            text = Convert.ToString(int1);
            text = Convert.ToString(dbl1);



            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            char key = Console.ReadKey().KeyChar;
            Console.WriteLine(key);
            Console.ReadKey();




            //// MIXING TYPES
            //int int1 = 13;
            //double dbl1 = 5.123;
            //string str1 = "hallo";

            //double dbl2 = int1; // is this possible, can we put an int in a double?
            //string str2 = "het getal is " + int1; // is this possible, can we add an int to a string?
            //string str3 = int1; // is this possible, can we put an int in a string?
            //int int2 = dbl1; // is this possible, can we put a double in an int?
            //int int3 = int1 / 4; // is this possible, can we put 13 / 4 in an int? Result 3
            //double dbl3 = int1 / 4; // is this possible, can we put 13 / 4 in a double? Result 3.0
            //int int4 = str1 * 2; // is this possible, can we multiply a string?


        }
    }
}
