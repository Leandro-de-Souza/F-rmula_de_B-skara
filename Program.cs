﻿using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROBLEMA_BASKARA {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            double x1, x2, a, b, c, delta;

            Console.Write("Coeficiente a: ");
            a = double.Parse(Console.ReadLine(), CI);
            Console.Write("Coeficiente b: ");
            b = double.Parse(Console.ReadLine(), CI);
            Console.Write("Coeficiente c: ");
            c = double.Parse(Console.ReadLine(), CI);

            delta = (b * b) - (4 * a * c);

            if (a == 0 || delta < 0) {
                Console.WriteLine("Esta equacao nao possui raizes reais");
            }

            else {
                x1 = ((-b) + Math.Sqrt(delta)) / (2 * a);
                x2 = ((-b) - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("X1 = " + x1.ToString("F4", CI));
                Console.WriteLine("X2 = " + x2.ToString("F4", CI));
            }


        }
    }
}
