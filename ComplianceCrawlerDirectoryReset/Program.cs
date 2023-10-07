using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace ComplianceCrawlerDirectoryReset
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> loggedMoves = new List<string>();
            int result = 0;
            loggedMoves.Add("x/");
            loggedMoves.Add("y/");
            loggedMoves.Add("../");
            loggedMoves.Add("z/");
            loggedMoves.Add("./");

            foreach (var item in loggedMoves)
            {
                switch (item)
                {
                    case "./":
                        break;

                    case "../":
                        result--;
                        break;

                    default:
                        result++;
                        break;
                }
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}





