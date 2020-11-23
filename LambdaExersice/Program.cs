using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExersice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> { "Kostas","Dimitris","Maria","Manolis","Dionisis"};

            IEnumerable<string> filteredNames = new List<string>(names).Where(NamesStartWithM);
            foreach (var item in filteredNames)
            {
                Console.WriteLine($"{item}");
            }


            IEnumerable<string> filteredNames2 = new List<string>(names).Where( x => x.StartsWith("M"));
            foreach (var item in filteredNames2)
            {
                Console.WriteLine($"{item}");
            }




        }

        private static bool NamesStartWithM(string name)
        {
            return (name.StartsWith("M"));
        }
    }
}
