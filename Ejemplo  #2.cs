using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_conversiones_2
{
    class Program
    {
        static void Main(string[] args)
        {   int opcion = 0, v1 = 0, v3 = 0, v4 = 0;
            string result = null;
            int r3 = 0, r4= 0;
            Program ob = new Program();
            Console.Out.WriteLine("Conversiones");
            Console.Out.WriteLine("Menú, marca el número que deseas ejecutar ");
            Console.WriteLine(" Decimal -> Hexadécimal    1");
            Console.WriteLine(" Hexadécimal -> Decimal    2");
            Console.WriteLine(" Octal -> Décimal          3");
            Console.WriteLine(" Binario -> Decimal        4");
            opcion = int.Parse(Console.ReadLine());            
            if (opcion == 1)
            {Console.WriteLine("\t\t\tUsted eligió: 1, Decimal -> Hexadécimal");                
                Console.WriteLine("Digite una variable");
                v1 = int.Parse(Console.ReadLine());
                result = ob.hexadecimal(v1);
                Console.WriteLine("El Hexadecimal de " + v1 + " es " + result);
            }
            else if (opcion == 2)
            {Console.WriteLine("\t\t\tUsted eligió: 2, Hexadécimal -> Decimal");
                Console.WriteLine("Digite una variable");
                string Hexag = Console.ReadLine();
                string[] variable = Hexag.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (String hex in variable)
                {   int valor = Convert.ToInt32(hex, 16);
                    Console.WriteLine("El Hexadecimal de " + Hexag + " es ");
                    Console.WriteLine(string.Format("{0} = {1}", hex, Convert.ToDecimal(valor)));
                }
            }
            else if (opcion == 3)
            {   Console.WriteLine("\t\t\tUsted eligió: 3, Octal -> Décimal");
                Console.WriteLine("Digite una variable");
                v3 = int.Parse(Console.ReadLine());
                r3 = ob.octalDecimal(v3);
                Console.WriteLine("El decimal de " + v3 + " es " + r3);
            }
            else if (opcion == 4)
            {  Console.WriteLine("\t\t\tUsted eligió: 4, Binario -> Decimal");
                Console.WriteLine("Digite una variable");
                v4 = int.Parse(Console.ReadLine());
                r4 = ob.binarioDecimal(v4);
                Console.WriteLine("El decimal de " + v4 + " es " + r4);
            }
            Console.ReadKey();
        }
        private String hexadecimal(int nm)
        {
            if (nm.ToString() != getValor(nm))
            {
                return getValor(nm);
            }
            String nm2 = getValor(nm % 16);
            if (nm >= 16)
            {
                int resto = nm / 16;
                string restoString = hexadecimal(resto);
                Console.WriteLine(restoString);

                return restoString + nm2;
            }
            return nm.ToString();
        }

        private String getValor(int nm)
        {
            switch (nm)
            {
                case 10: return "A";
                case 11: return "B";
                case 12: return "C";
                case 13: return "D";
                case 14: return "E";
                case 15: return "F";
            }
            return nm.ToString();
        }
        private int octalDecimal(long octal)
        {   int nm = 0;
            int nm2 = 0;
            const int DIVISOR = 10;

            for (long K= octal, A= 0; K> 0; K/= DIVISOR,A++)
            {   nm2 = (int)K% DIVISOR;
                if (!(nm2 >= 0 && nm2 <= 7))
                {
                    return -1;
                }
                nm += nm2 * (int)Math.Pow(8,A);
            }

            return nm;
        }
        private int binarioDecimal(long binario)
        {   int nm = 0;
            int nm2 = 0;
            const int DIVISOR = 10;

            for (long K= binario, A= 0; K> 0; K/= DIVISOR,A++)
            {
                nm2 = (int)K% DIVISOR;
                if (nm2 != 1 && nm2 != 0)
                {
                    return -1;
                }
                nm += nm2 * (int)Math.Pow(2, A);
            }

            return nm;
        }


    }

}
