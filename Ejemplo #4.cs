using System;

namespace ejercicio conversiones_1
{
    class Program
    {   
        static void Main(string[] args)
        {
            int numero = 0,linea;
            string result = null;
            string digito = null;
            Program ob = new Program();


            Console.Out.WriteLine("Programa para calcular conversiones de decimal a octal o binario\n ");
            Console.WriteLine("ingrese el numero entero a convertir :\n");
            numero = int.Parse(Console.ReadLine());
            Console.Out.WriteLine("Elija a continuacion la opcion de conversion:\n ");
            Console.WriteLine("1.Conversion de decimal a binaria\n");
            Console.WriteLine("2.Conversion de decimal a octal\n");
            linea =int.Parse(Console.ReadLine());

            if (linea ==1)

            { 
            result = ob.BINARIO(numero);


            Console.WriteLine();
            Console.WriteLine("El valor binario de " + numero + " es " + result);
            Console.WriteLine();
            }
            else
            {
                digito = ob.Octal(numero);


                Console.WriteLine();
                Console.WriteLine("El valor octal de " + numero + " es " + digito);
                Console.WriteLine();


            }

            Console.ReadKey();
        }


        private string BINARIO(int numero)
        {
            string resto = "";
            string binario = "";

            while ((numero >= 2))
            {
                resto = resto + (numero % 2).ToString();
                numero = numero / 2;
            }
            resto = resto + numero.ToString();

            for (int i = resto.Length; i >= 1; i += -1)
            {
                binario = binario + resto.Substring(i - 1, 1);
            }

            return binario;
        }
        private String Octal(int numero)
        {
            String digito = Convert.ToString(numero % 8);
            if (numero >= 8)
            {
                string restoString = Octal(numero / 8);
                return restoString + digito;
            }
            return digito;

        }

    }
}
