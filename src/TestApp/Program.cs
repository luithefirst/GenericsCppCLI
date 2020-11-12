using CSharpLibrary;
using NativeWrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var ext = new MyWrapper();
            var vec = new Vector<float>(100);
            ext.Process(vec);
            Console.ReadKey();
        }
    }
}
