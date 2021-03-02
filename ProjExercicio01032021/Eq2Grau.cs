using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjExercicio01032021
{
    class Eq2Grau
    {
        public int Eq2()
        {
            double a, b, c;
            Console.WriteLine("Calculadora da Equação 2 Grau");

            Console.WriteLine("Informe o valor de A:");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor de B:");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor de C:");
            c = double.Parse(Console.ReadLine());

            double delta = ((b * b) - (4 * a * c));

            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);

            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine("O valor de x1 é igual a:" + x1);

            Console.WriteLine("O valor de x2 é igual a:" + x2);
            Console.ReadKey();
            return 0;
        }
    }
}

