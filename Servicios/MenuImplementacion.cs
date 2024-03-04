using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jpribioExamen.Servicios
{
    /// <summary>
    /// Implementacion donde implementa la interfaz del menu
    /// JPR-04/03/2024
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public int menuPrincipal()
        {
            
            int opcion;
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Opcion 0. Cerrar menu.");
            Console.WriteLine("Opcion 1. Version Empleado.");
            Console.WriteLine("Opcion 2. Version gerencia.");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Elija una opcion por favor.");
            opcion = Int32.Parse(Console.ReadLine());
            return opcion;
        }

        public int menuEmpelado()
        {
            int opcion;
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Opcion 0. Volver al menu principal.");
            Console.WriteLine("Opcion 1. Añadir venta.");
            Console.WriteLine("Opcion 2. Calculo total de ventas diario.");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Elija una opcion por favor.");
            opcion = Int32.Parse(Console.ReadLine());
            return opcion;
        }

        public int menuProveedor()
        {
            int opcion;
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Opcion 0. Volver al menu principal.");
            Console.WriteLine("Opcion 1. Mostrar ventas del dia.");
            Console.WriteLine("Opcion 2. Crear pedido para proveedores.");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Elija una opcion por favor.");
            opcion = Int32.Parse(Console.ReadLine());
            return opcion;
        }
    }
}
