using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tb_de_multiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 0, x2 = 0, x3 = 0, x4 = 0;
            int Linea;
            Console.Write("Hola! \nDígita porfa los cuatro números que quieres operar:\n");
            Console.Write("Los dos primeros números serán las tablas de multiplicar y\n  los dos ultimos el intervalo de dichas tablas a mostrar");
            x1 = int.Parse(Console.ReadLine());
            x2 = int.Parse(Console.ReadLine());
            x3 = int.Parse(Console.ReadLine());
            x4 = int.Parse(Console.ReadLine());

            if (x1 < x2)
            {
                if (x3 < x4)
                {
                    for (int n = x1; n <= x2; n += 1)
                    {
                        for (int a = x3; a <= x4; a += 1)
                        {
                            Linea = n * a;
                            Console.WriteLine("su resultado es :" + n + "x" + a + "=" + Linea);
                        }
                    }
                }
                else if (x3 > x4)
                {
                    for (int n = x1; n <= x2; n += 1)
                    {
                        for (int a = x3; a >= x4; a -= 1)
                        {
                            Linea = n * a;
                            Console.WriteLine("su resultado es :" + n + "x" + a + "=" + Linea);
                        }
                    }
                }


            }
            else
            {
                if (x3 < x4)
                {
                    for (int n = x1; n >= x2; n -= 1)
                    {
                        for (int a = x3; a <= x4; a += 1)
                        {
                            Linea = n * a;
                            Console.WriteLine("su resultado es :" + n + "x" + a + "=" + Linea);
                        }
                    }
                }
                else
                {
                    for (int n = x1; n >= x2; n -= 1)
                    {
                        for (int a = x3; a >= x4; a -= 1)
                        {
                            Linea = n * a;
                            Console.WriteLine("su resultado es :" + n + "x" + a + "=" + Linea);
                        }
                    }
                }
            }
            Console.ReadKey();
            Console.Out.Write("Gracias por utilizar nuestro programa! \nAdiós...");
            Console.ReadKey();

        }
    }
}
