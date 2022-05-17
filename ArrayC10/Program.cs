﻿using System;

namespace Clase10_D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string[] empleados = { "Federico", "Julian", "Camila" };

            int cantElementos = empleados.Length;

            //Recorrer un array de atrás para adelante
            for (int i = cantElementos - 1; i >= 0; i--)
            {
                Console.WriteLine(empleados[i]);
            }
            */

            const string MJE_INGRESO_INVITADOS = "Ingrese el nombre #";
            const string MJE_INGRESO_EDAD = "Ingrese la edad #";
            const string MJE_BUSQUEDA_INV = "Ingrese el nombre del invitado a buscar:";
            const string MJE_BUSQUEDA_EMP = "Ingrese el nombre del empleado a buscar:";
            
           string[] invitadosFiesta = new string[5];
           int[] edades = new int[5];

           CargarArray(invitadosFiesta, MJE_INGRESO_INVITADOS);
           CargarArray(edades, MJE_INGRESO_EDAD);

           MostrarArray(invitadosFiesta);
           MostrarArray(edades);

           Sumar(edades, 10);

           MostrarArray(edades);

           string terminoABuscar = IngresarString(MJE_BUSQUEDA_INV);
           int indexInvitado = BuscarElemento(invitadosFiesta, terminoABuscar);
           Console.WriteLine(indexInvitado == -1 ? "No se encontro el invitado." : "Se encontro en la posicion " + indexInvitado);
           
            //Vectores paralelos
            string[] empleados = { "Federico", "Julian", "Camila" };
            double[] sueldos = { 45000, 80000, 125432 };

            /*
             * 1. Ingreso el nombre del empleado a buscar.
             * 2. SI LO ENCUENTRO... Accedo directamente al array de sueldos con esa posición.
             * 3. Muestro el sueldo obtenido en el paso anterior.
             */

            string empleadoABuscar = IngresarString(MJE_BUSQUEDA_EMP);
            int indexEmpleado = BuscarElemento(empleados, empleadoABuscar);
            if (indexEmpleado != -1)
            {
                //Encontré al empleado.
                Console.WriteLine($"{empleadoABuscar} gana ${sueldos[indexEmpleado]}");
            }
            else
            {
                Console.WriteLine("No se encontro el empleado buscado.");
            }

        }

        //Busqueda Lineal o Secuencial
        //"Federico", "Julian", "Camila". Quiero Buscar Camila
        static int BuscarElemento(string[] array, string elementoABuscar)
        {
            int i = 0;
            while ( array.Length != i && array[i] != elementoABuscar )
            {
                i++;
            }

            if(i == array.Length)
            {
                i = -1;
            }

            //return i == array.Length ? -1 : i; Operador ternario. Si uso esto no uso el if
            return i;
        }

        static void Sumar(int[] array, int nro)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] += nro;
            }
        }

        static void CargarArray(string[] array, string mensaje)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = IngresarString($"{mensaje}{i + 1}:");
            }
        }

        //CargarArray ya existe. Pero puedo hacer una sobrecarga y poner otra cant. de parámetros y/o de otro tipo.
        static void CargarArray(int[] array, string mensaje)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = IngresarEntero($"{mensaje}{i + 1}:");
            }
        }

        static void MostrarArray(string[] array)
        {
            /*for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}\t");
            }*/

            foreach (string elementoActual in array)
            {
                Console.Write($"{elementoActual}\t");
            }

            Console.WriteLine();
        }
        static void MostrarArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}\t");
            }
            Console.WriteLine();
        }

        static string IngresarString(string mensaje)
        {
            Console.WriteLine(mensaje);
            return Console.ReadLine();
        }

        static int IngresarEntero(string mensaje)
        {
            Console.WriteLine(mensaje);
            return int.Parse(Console.ReadLine());
        }
    }
}
