using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParse____Bruh_
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;

           
            Console.WriteLine("Give me a numbah");

            if (!TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("This ain't no goddamn number. Try again");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("The numbah was goddamn:" + x);
                Console.ReadKey();
            }

        }

        public static bool TryParse(string s, out int x)
        {

            try
            {
                x = int.Parse(s);

                return true;

            }
            catch
            {
                x = 0;

                return false;
            }

        }

    }

}
