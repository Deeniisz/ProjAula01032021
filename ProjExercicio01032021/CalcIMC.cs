using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjExercicio01032021
{
    class CalcIMC
    {
        public int Calculo()
        {
            Console.WriteLine("Informe o Peso");
            float peso = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe a Altura");
            float altura = float.Parse(Console.ReadLine());
            float IMC = peso / (altura * altura);

            if (IMC < 18.5)
            {
                Console.WriteLine("IMC: " + IMC);
                Console.WriteLine("Magreza");
            }
            else
            {
                if (IMC > 18.5 && IMC < 24.9)
                {
                    Console.WriteLine("IMC: " + IMC);
                    Console.WriteLine("Normal");
                }
                else 
                {
                    if (IMC > 25 && IMC < 29.9)
                    {
                        Console.WriteLine("IMC: " + IMC);
                        Console.WriteLine("Sobrepeso");
                    }
                    else 
                    {
                        if (IMC > 30 && IMC < 39.9)
                        {
                            Console.WriteLine("IMC: " + IMC);
                            Console.WriteLine("Obesidade");
                        }
                        else 
                        {
                            if (IMC > 40)
                            {
                                Console.WriteLine("IMC: " + IMC);
                                Console.WriteLine("Obesidade Grave");
                            }
                        }
                    }
                }
            }
            Console.ReadKey();
            return 0;
        }
    }
}
