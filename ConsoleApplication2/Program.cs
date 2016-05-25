using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
            static int opcion = 0;
            static int montoDeposito = 0;            
            static int suma = 0;
            static int moneda = 0;
            static int contadorCantidad5 = 0;
            static int contador5 = 0;
            static int contadorCantidad10 = 0;
            static int contador10 = 0;
            static int contadorCantidad25 = 0;
            static int contador25 = 0;
            static int contadorCantidad50 = 0;
            static int contador50 = 0;
            static int contadorCantidad100 = 0;
            static int contador100 = 0;
            static int contadorCantidad500 = 0;
            static int contador500 = 0;
            static int multiplicacion = 0;
            static double division = 0;
            static int monto = 0;
            static DateTime now = DateTime.Now;
            static int[] cuenta = new int[1]{0};
            
            
            static void depositar_dinero(){
                Console.Clear();
                Console.WriteLine("Ingrese el monto a depositar");
                montoDeposito = int.Parse(Console.ReadLine());
                Console.WriteLine("El saldo anterior era " + cuenta[0]);
                suma = cuenta[0] + montoDeposito;
                cuenta[0] = suma;
                Console.WriteLine("El monto actual es " + suma);
                Console.ReadKey();
            }

            static void retirar_dinero() {
                Console.Clear();
                Console.WriteLine("El monto disponible en su cuenta es de " + cuenta[0]);
                Console.WriteLine("Ingrese el monto que desea retirar");
                monto = int.Parse(Console.ReadLine());
                if (cuenta[0] != 0)
                {
                    if (monto <= cuenta[0])
                    {
                        do{

                        }while();
                    }
                    else {
                        Console.WriteLine("El monto que quiere retirer es superior al monto de su cuenta");
                    }
                }
                else
                {
                    Console.WriteLine("No tiene fondos en su cuenta para retirar dinero");
                }
                Console.ReadKey();
            }

            static void recibir_monedas() {
                Console.Clear();
                
                do
                {
                    Console.WriteLine("Ingrese la denominacion de monedas");
                    moneda = int.Parse(Console.ReadLine());
                    if (moneda == 5)
                    {
                        contadorCantidad5 = contadorCantidad5 + 1;
                        contador5 = contador5 + 5;
                    }
                    else if (moneda == 10)
                    {
                        contadorCantidad10 = contadorCantidad10 + 1;
                        contador10 = contador10 + 10;
                    }
                    else if (moneda == 25)
                    {
                        contadorCantidad25 = contadorCantidad25 + 1;
                        contador25 = contador25 + 25;
                    }
                    else if (moneda == 50)
                    {
                        contadorCantidad50 = contadorCantidad50 + 1;
                        contador50 = contador50 + 50;
                    }
                    else if (moneda == 100)
                    {
                        contadorCantidad100 = contadorCantidad100 + 1;
                        contador100 = contador100 + 100;
                    }
                    else if (moneda == 500)
                    {
                        contadorCantidad500 = contadorCantidad500 + 1;
                        contador500 = contador500 + 500;
                    }
                    else
                    {
                        Console.WriteLine("Ingrese una denominacion valida");
                    }
                } while (moneda != 0);
                Console.WriteLine("La cantidad de monedas de denominacion 5 son " + contadorCantidad5 + " y suman " + contador5);
                Console.WriteLine("La cantidad de monedas de denominacion 10 son " + contadorCantidad10 + " y suman " + contador10);
                Console.WriteLine("La cantidad de monedas de denominacion 25 son " + contadorCantidad25 + " y suman " + contador25);
                Console.WriteLine("La cantidad de monedas de denominacion 50 son " + contadorCantidad50 + " y suman " + contador50);
                Console.WriteLine("La cantidad de monedas de denominacion 100 son " + contadorCantidad100 + " y suman " + contador100);
                Console.WriteLine("La cantidad de monedas de denominacion 500 son " + contadorCantidad500 + " y suman " + contador500);                
                Console.ReadKey();
            }

            static void indicar_tipodecambio() {
                Console.Clear();
                Console.WriteLine("1.De colones a dolares.\n2.De dolares a colones.");
                opcion = int.Parse(Console.ReadLine());
                if (opcion == 1)
                {
                    Console.WriteLine("Ingrese el monto en colones a convertir a dolares");
                    monto = int.Parse(Console.ReadLine());
                    division = monto / 546;
                    Console.WriteLine("El tipo de cambio " + now + " $" + division);
                }
                else {
                    Console.WriteLine("Ingrese el monto en dolares a convertir a colones");
                    monto = int.Parse(Console.ReadLine());
                    multiplicacion = monto * 534;
                    Console.WriteLine("El tipo de cambio " + now + " ₡" + multiplicacion);
                }
                Console.ReadKey();
            }

        static int Main()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Cajero Banco Estado");
                Console.WriteLine("1.Deposito de dinero.\n2.Retiro de dinero.\n3.Recibo de monedas.\n4.Consulta tipo de cambio.\n5.Salir.");
                opcion = int.Parse( Console.ReadLine());

                switch(opcion)
                {
                    case 1:
                        depositar_dinero();
                        break;
                    case 2:
                        retirar_dinero();
                        break;
                    case 3:
                        recibir_monedas();                      
                        break;
                    case 4:
                        indicar_tipodecambio();
                        break;                    
                    default:
                        Console.WriteLine("Ingrese un valor valido");
                        break;
                }
            } while (opcion != 5);
            return 0;
        }
    }
}
