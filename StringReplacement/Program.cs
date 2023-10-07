using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReplacement
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = ""; //asDbKeAgf
            string word = "as?b?e?gf";
            string substr = "dbk";

            string result2 = ""; // -1
            string word2 = "s?f??d?j";
            string substr2 = "abc";

            List<int> degisecekIndeks = new List<int>();
            int z = substr.Length;
            
            if (word.Count(h => h == '?') < substr.Length)
            {
                result = "-1";
            }

            for (int i = word.Length-1; i >= 0 ; i--)
            {
                if (word[i] == '?')
                {
                    degisecekIndeks.Add(i);
                }
            }
            int subsIndex = 0;
            foreach (var index in degisecekIndeks)
            {
               string dize = word.Substring(degisecekIndeks[index], z);
                foreach (var item in dize)
                {
                    if (item == '?' || item == substr[subsIndex])
                    {
                        
                    }
                    subsIndex++;
                }
            }
         




            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
