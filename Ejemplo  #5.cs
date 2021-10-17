using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salario_empleado
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nombre = "";
            double Cedula = 0, ventas = 0, comision = 0, subtotal = 0,result = 0, salud = 0, pension = 0;
            const double minimo = 895359, subtransporte = 102854;
            System.Console.Out.WriteLine("\t\t\tSALARIO MENSUAL");
            System.Console.Out.Write("Ingresa el nombre:\n ");
            Nombre = System.Console.ReadLine();
            System.Console.Out.WriteLine("Cc del empleado :");
            Cedula = float.Parse(System.Console.ReadLine());
            System.Console.Out.WriteLine("Ahora las ventas mensuales: ");
            ventas = float.Parse(System.Console.ReadLine());
            comision = (float)(ventas * 0.17);
            subtotal = (float)(comision + subtransporte + minimo);
            salud = (float)(minimo * 0.12);
            pension = (float)(minimo * 0.16);
           result = (float)(subtotal - (salud + pension));
            System.Console.Out.WriteLine("Señor/a"  + Nombre + ", con Cc." + Cedula + ":");
            System.Console.Out.WriteLine("Usted vendió $" + ventas + " pesos \ngenerando una comision de $" + comision + "\nmás el sub de trasporte por $" + subtransporte + " \ny salario mínimo" + minimo + ".\n = $" + subtotal + " \nSe descuenta $" + salud + " de salud y de pensión $" + pension );
            System.Console.Out.WriteLine("\nDando un total de: $" +result);
            System.Console.ReadKey();







        }
    }
}
