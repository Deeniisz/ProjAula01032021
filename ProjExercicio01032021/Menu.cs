using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjExercicio01032021
{
    class Menu
    {
        static void Main(string[] args)
        {

            int num;
            Console.WriteLine("MENU");
            Console.WriteLine("1 - EQUAÇÃO 2 GRAU");
            Console.WriteLine("2 - TRIANGULO");
            Console.WriteLine("3 - IMC");
            num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Eq2Grau equa = new Eq2Grau();
                    equa.Eq2();
                    break;
                case 2:
                    VerifTriangulo trian = new VerifTriangulo();
                    trian.Triangulo();
                    break;
                case 3:
                    CalcIMC calc = new CalcIMC();
                    calc.Calculo();
                    break;
            }

        
        }
    }
}