using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signo_Zodiacal
{
    class Program
    {
        private const int A = 1;
        private const int B = 2;
        private const int C = 3;
        private const int D = 4;
        private const int E = 5;
        private const int F = 6;
        private const int G = 7;
        private const int H = 8;
        private const int I = 9;
        private const int J = 10;
        private const int K = 11;
        private const int L = 12;


        static void Main(string[] args)
        {
            string nombre = "", signo = "", mespal = "";
            short edad = 0, dia = 0, mes = 0, anio = 0;
            bool bien = false;
            System.Console.Out.WriteLine("\t\t\tPROGRAMA PARA CALCULAR EL SIGNO ZODIACAL Y EL MES EN PALABRA");
            System.Console.Out.Write("Por favor digita tu nombre \n");
            nombre = System.Console.ReadLine();
            System.Console.Out.Write("ahora escribe tu fecha de nacimiento así (DD:MM:AA) \n ");
            dia = short.Parse(System.Console.ReadLine());
            mes = short.Parse(System.Console.ReadLine());
            anio = short.Parse(System.Console.ReadLine());
            if (mes < 1 || mes > 12 | dia > 31 || dia < 1 || anio < 1900 || anio > DateTime.Now.Year)
            {
                System.Console.WriteLine("fecha de nacimiento incorrecta, por favor verifique e inicie nuevamente la ejecución");
            }
            else if (mes == 1 && dia >= 20 || mes == 2 && dia <= 18)
            {
                signo = "ACUARIO";
                bien = true;
            }
            else if (mes == 2 && (dia >= 19 && dia <= 29) || mes == 3 && dia <= 18)
            {
                signo = "PISCIS";
                bien = true;
            }
            else if (mes == 3 && dia >= 20 || mes == 4 && dia <= 18)
            {
                signo = "ARIES";
                bien = true;
            }

            else if (mes == 4 && (dia >= 19 || dia <= 30) || mes == 5 && dia <= 18)
            {
                signo = "TAURO";
                bien = true;
            }
            else if (mes == 5 && dia >= 20 || mes == 6 && dia <= 18)
            {
                signo = "GEMINIS";
                bien = true;
            }
            else if (mes == 6 && (dia >= 19 && dia <= 30) || mes == 7 && dia <= 18)
            {
                signo = "CANCER";
                bien = true;
            }
            else if (mes == 7 && dia >= 20 || mes == 8 && dia <= 18)
            {
                signo = "LEO";
                bien = true;
            }
            else if (mes == 8 && dia >= 20 || mes == 9 && dia <= 18)
            {
                signo = "VIRGO";
                bien = true;
            }
            else if (mes == 9 && (dia >= 19 && dia <= 30) || mes == 10 && dia <= 18)
            {
                signo = "LIBRA";
                bien = true;
            }
            else if (mes == 10 && (dia >= 19 && dia <= 31) || mes == 11 && dia <= 18)
            {
                signo = "ESCORPIO";
                bien = true;
            }
            else if (mes == 11 && (dia >= 19 && dia <= 30) || mes == 12 && dia <= 18)
            {
                signo = "SAGITARIO";
                bien = true;
            }
            else if (mes == 12 && (dia >= 19 && dia <= 31) || mes == 1 && dia <= 18)
            {
                signo = "CAPRICORNIO";
                bien = true;
            }
            else
            {
                System.Console.WriteLine("fecha de nacimiento incorrecta, por favor verifique e inicie nuevamente la ejecución");
            }
            if (bien == true)
            {
                switch (mes)
                {
                    case A:
                        mespal = "ENERO";
                        break;
                    case B:
                        mespal = "FEBRERO";
                        break;
                    case C:
                        mespal = "MARZO";
                        break;
                    case D:
                        mespal = "ABRIL";
                        break;
                    case E:
                        mespal = "MAYO";
                        break;
                    case F:
                        mespal = "JUNIO";
                        break;
                    case G:
                        mespal = "JULIO";
                        break;
                    case H:
                        mespal = "AGOSTO";
                        break;
                    case I:
                        mespal = "SEPTIEMBRE";
                        break;
                    case J:
                        mespal = "OCTUBRE";
                        break;
                    case K:
                        mespal = "NOVIEMBRE";
                        break;
                    case L:
                        mespal = "DICIEMBRE";
                        break;


                }
                edad = (short)(System.DateTime.Now.Year - anio);
                System.Console.Clear();
                System.Console.Out.WriteLine("informe del signo zodiacal, la edad y fecha de nacimiento con el mes en palabra");
                System.Console.Out.WriteLine("EL SEÑOR (A) " + nombre + " TU FECHA DE NACIMIENTO ES EL " + dia.ToString() + "/" + mespal.ToString() +
                    "/" + anio.ToString() + ", " + edad.ToString() + " AÑOS Y FINALMENTE ERES SIGNO " + signo + "");




            }
            System.Console.ReadKey();
        }
    }
}
