
using ConsoleSharp.BackToBasics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bom dia");
            Console.Write("Boa tarde");
            Console.ReadLine();
            var enumee = new Enumeration();
            enumee.LoopEnumGetNames();
            enumee.LoopEnumGetValues();

        }
    }
}
