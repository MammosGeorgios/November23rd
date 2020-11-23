using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            //Func<int, int> square = x => x * x;

            //Func<int, int, int> add = (x, y) => x + y;

            //// Console.WriteLine(add(1,2));


            //Action<int> write = x => Console.WriteLine(x);

            //write.Invoke(add.Invoke(1, 2));



            string[] words = { "a", "a", "a", "a", "a","dasdsad", "asds", "dadsad", "asdasdad", "asdasdas", "a" };

            var shortwords = words.Where((digit, index) => digit.Length < index  );
            
          

            
            int i = 0;


            foreach (var item in shortwords)
            {
                i++;
            }
            Console.WriteLine(i);



          

        }
    }
}
