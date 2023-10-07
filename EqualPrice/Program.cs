using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> price = new List<int>();
            List<int> query = new List<int>();
            
            price.Add(2);
            price.Add(5);
            price.Add(1);
            query.Add(8);
            query.Add(4);
            query.Add(3);

            long[] result = new long[query.Count()];
            int i = 0;
            
            foreach (var q in query)
            {
                long op = 0;
                foreach (var p in price)
                {
                    op = Math.Abs(q - p);
                    result[i] += op;
                }
                Console.WriteLine(result[i]);
                i++;
            }

            Console.ReadKey();
        }
    }
}
