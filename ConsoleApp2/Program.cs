using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Vector vector1 = new Vector(20, 30);
            Vector vector2 = new Vector(45, 70);
            Vector vectorResult = new Vector();

            // vectorResult is equal to (65,100)
            vectorResult = vector1 + vector2;

        }
    }
}
