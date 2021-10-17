using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SALARIOCOMISIONES2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string nombre = "";
            int  ID = 0;
            double ventasmens = 0, comision = 0, TotalAPagar = 0, salarioMin = 877802, SubTranspo = 102853, descuentoSalud = 35113, descuentoPensión = 35113, valorfinal=0;
            System.Console.Out.WriteLine("\t\t\tPROGRAMA PARA CALCULAR EL SALARIO Y COMISIONES");
            System.Console.Out.Write("Por favor digita tu nombre \n");
            nombre = System.Console.ReadLine();
            System.Console.Out.Write("ahora escribe tu Cédula de ciudadanía\n");
            ID = int.Parse(System.Console.ReadLine());
            System.Console.Out.Write("ahora escribe tus ventas mensuales\n");
            ventasmens = double.Parse(System.Console.ReadLine());
            if (ventasmens <= 1)
            {
                System.Console.WriteLine("cantidad de ventas incorrecta, por favor verifique e inicie nuevamente la ejecución\n");
                System.Console.ReadKey();
                Environment.Exit(-1);
            }
            else if (ventasmens <= 1200000)
            {               
                comision = 0;
                TotalAPagar= ((salarioMin + comision)- (descuentoSalud+ descuentoPensión));
            }
            else if (ventasmens <= 3000000)
            {
                comision =(ventasmens * 0.06);
                TotalAPagar = ((salarioMin + comision ) - (descuentoSalud + descuentoPensión));
            }
            else if (ventasmens <= 8000000)
            {
                comision = (ventasmens * 0.11);
                TotalAPagar = ((salarioMin + comision ) - (descuentoSalud + descuentoPensión));
            }

            else if (ventasmens <= 15000000)
            {
                comision = (ventasmens * 0.15);
                TotalAPagar = ((salarioMin + comision) - (descuentoSalud + descuentoPensión));
            }
            else
            {
                System.Console.WriteLine("datos incorrectos, por favor verifique e inicie nuevamente la ejecución\n");
                System.Console.ReadKey();
                Environment.Exit(-1);
            }
            if (TotalAPagar<1700000) 
            {
                valorfinal = TotalAPagar + SubTranspo;

            }
            else 
            { valorfinal = TotalAPagar; }

                System.Console.Clear();
                System.Console.Out.WriteLine("\t\t\tINFORME DE NÓMINA\n");
                System.Console.Out.WriteLine("El vendedor  (a) " + nombre + " identificado con la cédula de cuidadanía " + ID.ToString() + "\ntuvo un total de ventas mensuales de " + ventasmens.ToString() +
                    "para sacar una comisión de" + comision.ToString() + "\nque sumado al salario mínimo legal vigente " + salarioMin.ToString() + "\n y descontando el debido porcentaje de salud y pension, da un total a pagar de $" + valorfinal + "en el mes.\nRecuerda que si tienes en nómina un valor mayor a 1.700.000 no se te contará el subsidio de transporte.\n Que tengas un excelente día!");





        
        System.Console.ReadKey();
        }
    }
}
