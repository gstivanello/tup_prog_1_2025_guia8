using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Declaracion de variables
            int contador, acumulador, cantidad;
            int num, maximo, minimo;
            double prom;
            #endregion

            #region Inicializacion de variables
            contador = 0;
            acumulador = 0; 
            maximo = 0;
            minimo = 10000;

            #endregion

            #region Solicitar cantidad de ingresos
            Console.WriteLine("Ingrese la cantidad de ingresos");
            cantidad = Convert.ToInt32(Console.ReadLine());
            #endregion

            #region Iterar ingresos
            if (cantidad != 0)
            {
                for (int i = 0; i < cantidad; i++)
                {
                    Console.WriteLine("Ingrese un valor");
                    num = Convert.ToInt32(Console.ReadLine());
                    acumulador = acumulador + num;
                    contador = contador++;

                    if (contador == 1 || maximo > num)
                    {
                        maximo = num;
                    }
                    else
                    if (contador == 1 || minimo < num)
                    {
                        minimo = num;
                    }
                }
                #region Mostrar en pantalla 
                prom = acumulador / cantidad;
                Console.WriteLine($"El maximo es: {maximo} \n El minimo es: {minimo} \n El promedio es: {prom}");
                Console.ReadKey();
                #endregion
            }
            #endregion

            else
            {
                if (cantidad == 0)
                {
                    Console.WriteLine("No se ingresaron numeros");
                    Console.ReadKey();
                }
            }

        }
    }
}
