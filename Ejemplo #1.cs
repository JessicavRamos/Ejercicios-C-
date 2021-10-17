using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parqueadero
{
    class Programa_final
    {
        static void Main(string[] args)
        {
            String[] placa;
            String[] nombre;
            short[] horassal;
            short[] minutossal;
            String[] placa1;
            String[] nombre1;
            short[] horassal1;
            short[] minutossal1;
            short[] horasreti;
            short[] minutosreti;
            double[] caja;
            double[] caja1;
            placa = new String[15];
            nombre = new String[15];
            horassal = new short[15];
            minutossal = new short[15];
            placa1 = new String[15];
            nombre1 = new String[15];
            horassal1 = new short[15];
            minutossal1 = new short[15];
            horasreti = new short[15];
            minutosreti = new short[15];
            caja = new double[20];
            caja1 = new double[20];
            int z = 0, x = 0, menu = 0;
            string linea, placausa = "";
            double dehora = 0, retiro = 0, ultima = 0, final1 = 0;
            short const1 = 1;
            double suma = 0;
            short hora = 0;
            short minuto = 0;
            while (menu != 6)
            {
                Console.Write("\t\t\t PARQUEADERO \n\n");
                Console.Write("1. Ingresar nuevo vehiculo \n");
                Console.Write("2. Retirar vehiculo \n");
                Console.Write("3. Validar estado vehiculo \n");
                Console.Write("4. Reporte parqueadero \n");
                Console.Write("5. Ingresos caja \n");
                Console.Write("6. salir   \n \n");
                linea = Console.ReadLine();
                menu = int.Parse(linea);
                if (menu == 1) // 1 punto menu ingreso vehiculo
                {
                    Console.Write("\t\t\t INGRESAR NUEVO VEHICULO  \n\n");

                    Console.Write("\nParqueadero deseado numero: "); /* esto es para ingresar la posicion */
                    linea = Console.ReadLine();
                    z = int.Parse(linea);

                    if (horassal[z] == 0)
                    {
                        for (int y = 0; y < 4; y++)

                        {
                            if (y == 0)
                            {

                                Console.Write(+(y + 1) + " " + ") Placa vehiculo \n");
                                linea = Console.ReadLine();
                                placa[z] = linea;
                            }
                            if (y == 1)
                            {
                                Console.Write(+(y + 1) + " " + ") Nombre titular vehiculo \n");
                                linea = Console.ReadLine();
                                nombre[z] = linea;
                            }
                            if (y == 2)
                            {
                                Console.Write(+(y + 1) + " " + ") Hora entrada vehiculo \n");
                                linea = Console.ReadLine();
                                hora = short.Parse(linea);

                                if (hora >= 0 & hora <= 24)
                                {
                                    horassal[z] = hora;
                                }
                                else
                                {
                                    Console.Write("\t\t\t *** Hora invalida *** \n\n");
                                }
                            }
                            if (y == 3)
                            {
                                Console.Write(+(y + 1) + " " + ") Minutos entrada vehiculo \n");
                                linea = Console.ReadLine();
                                minuto = short.Parse(linea);
                                if (minuto >= 0  & minuto <= 60)
                                {
                                    horassal[z] = minuto;
                                }
                                else
                                {
                                    Console.Write("\t\t\t *** Minutos invalidos *** \n\n");
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.Write("\n  \tParqueadero ocupado en el momento \n");
                    }
                }
                if (menu == 2) // 1 punto menu estado vehiculo
                {
                    Console.Write("\t\t\t RETIRAR VEHICULO  \n\n");
                    Console.Write("\n   Ingrese numero de parqueadero a liquidar \n"); /* esto es para ingresar la posicion */
                    linea = Console.ReadLine();
                    z = int.Parse(linea);
                    Console.Write("\n  Ingrese hora del retiro en parqueadero \n"); /* esto es para ingresar la posicion */
                    linea = Console.ReadLine();
                    hora = short.Parse(linea);
                    if (hora >= 0 & hora <= 24)
                    {
                        horasreti[z] = hora;
                        if (horasreti[z] >= horassal[z])
                        {
                            Console.Write("\n  Ingrese minutos del retiro en parqueadero \n"); /* esto es para ingresar la posicion */
                            linea = Console.ReadLine();
                            minuto = short.Parse(linea);
                            if (minuto >= 0 & minuto <= 60)
                            {
                                minutosreti[z] = minuto;
                                /* liquida = horasreti[z] - horassal[z]; */
                                /* dehora = ((liquida * 60) * 72);  */
                                retiro = horasreti[z] - horassal[z] - const1;
                                ultima = 60 - minutossal[z];
                                final1 = (retiro * 60) + ultima + minutosreti[z];
                                dehora = (final1 * 72);
                            }
                            else
                            {
                                Console.Write("\t\t\t *** Minutos invalidos *** \n\n");
                            }
                            caja[z] = (dehora);
                            Console.Write("\n  los minutos de la estancia del vehiculo en el parqueadero son :" + " " + final1 + " " + "minutos");
                            Console.Write("\n  El valor a pagar del vehiculo en el parqueadero es : " + "$" + dehora + " " + "pesos\n\n");
                        }
                        else
                        {
                            Console.Write("\t\t\t *** Hora invalida *** \n\n");
                        }
                    }
                    else
                    {
                        Console.Write("\n ***************** Hora de salida erronea, recuerde ingresar la hora en formato de 24hrs.***************** \n");
                        Console.ReadKey();
                    }
                    Console.ReadKey();
                    for (int y = 0; y < 4; y++)
                    {
                        if (y == 0)
                        {
                            placa1[x] = placa[z];
                            placa[z] = null;
                        }
                        if (y == 1)
                        {
                            nombre1[x] = nombre[z];
                            nombre[z] = null;
                        }
                        if (y == 2)
                        {
                            horassal1[x] = horassal[z];
                            horassal[z] = 0;
                        }
                        if (y == 3)
                        {
                            minutossal1[x] = minutossal[z];
                            minutossal[z] = 0;
                        }
                    }
                    x++;
                    caja1[x] = caja[z];
                    x++;
                }
                if (menu == 3) // 1 punto menu estado vehiculo
                {
                    Console.Write("\t\t\t ESTADO DEL VEHICULO  \n\n");
                    Console.Write("\n  \t\t\t ingresa la placa a validar\n");
                    placausa = Console.ReadLine();
                    for (int i = 0; i < 15; i++)
                    {
                        if (placa[i] == placausa)
                        {
                            Console.WriteLine("\nEl carro se encuentra en el parqueadero No.: " + i);
                        }

                    }
                    for (int i = 0; i < x; i++)
                    {
                        if (placa1[i] == placausa)
                        {
                            Console.WriteLine("\nEl carro esta registrado como liquidado ");
                        }
                    }
                }
                if (menu == 4) // 1 punto menu ingreso vehiculo
                {
                    Console.Write("\t\t\t REPORTE PARQUEADERO  \n\n");
                    Console.WriteLine("-listado placas:\n");
                    for (int i = 0; i < 15; i++)
                    {
                        if (placa[i] != null)
                        {
                            Console.WriteLine("Parqueadero " + i + " vehículo: " + placa[i] + " a nombre de " + nombre[i] + " ingresado " + horassal[i] + ":" + minutossal[i]);
                        }
                        else
                        {
                            Console.WriteLine("Parqueadero " + i + " LIBRE. ");
                        }
                    }
                    Console.ReadKey();
                }
                if (menu == 5) // 1 punto menu liquidación vehiculo
                {
                    Console.Write("\t\t\t INGRESOS CAJA  \n\n");
                    Console.WriteLine("-listado pagos:\n");
                    for (int i = 0; i < x; i++)
                    {
                        if (caja1[i] != 0)
                        {
                            Console.WriteLine("  caja: $" + caja1[i]);
                            suma += caja1[i];
                        }
                    }
                    Console.WriteLine("La suma de la caja es :  " + suma);
                    Console.ReadKey();
                }
            }
            Console.Write("Programa finalizado ");
            Console.ReadKey();
        }
    }
}
