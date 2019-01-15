using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pw5
{
    class Program
    {
        public static void GenerateError()
        {
            CheckEmpty("");
        }
        public static void CheckEmpty(string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                throw new ArgumentNullException();
            }
        }
        static void Main(string[] args)
        {
            try
            {
                GenerateError();
            }
            catch (ArgumentNullException excrption)
            {
                Console.WriteLine(excrption.Message);
                Console.ReadLine();
            }
        }
    }
}
