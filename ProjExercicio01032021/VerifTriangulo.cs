using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjExercicio01032021
{
    class VerifTriangulo
    {
        public int Triangulo()
        {
            int a, b, c;
            Console.WriteLine("Verificador de Triangulo");
            Console.WriteLine("Informe o lado a:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o lado b:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o lado c:");
            c = int.Parse(Console.ReadLine());

            if (a == b && a == c && b == c)
            {
                Console.WriteLine("O Triangulo é Equilátero");
            }
            else
            {
                if (a == b || a == c || b == c)
                {
                    Console.WriteLine("O Triangulo é Isósceles");
                }
                else
                {
                    Console.WriteLine("O Triangulo é Escaleno");
                }
            }
            Console.ReadKey();
            return 0;
            
        } 
    }
}
