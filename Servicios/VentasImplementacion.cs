using jpribioExamen.Dtos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jpribioExamen.Servicios
{
    /// <summary>
    /// Clase que implementa la interfaz en relacion con las ventas y el empleado
    /// JPR-04/03/2024
    /// </summary>
    internal class VentasImplementacion : VentasInterfaz
    {

        /// <summary>
        /// Generador de id automatico 
        /// JPR-04/03/2024
        /// </summary>
        /// <param name="listaVentas">Lista de ventas</param>
        /// <returns></returns>
        public int idAutonumerico(List<VentasDtos> listaVentas)
        {
            int id; 
            int tamañoLista = listaVentas.Count;

            if(tamañoLista <=0)
            {
                id = 1;
            }else
            {
                id = listaVentas[tamañoLista - 1].Id + 1;
            }
            return id;
        }



        public void agregarVenta(List<VentasDtos> listaVentas)
        {
            int id = idAutonumerico(listaVentas);
            Console.WriteLine("Dame la cantidad de la venta");
            int cantidad = Int32.Parse(Console.ReadLine());   
            VentasDtos ventas = new VentasDtos(id, cantidad);
            listaVentas.Add(ventas);
        }

        public void calculoDeVentasDiario(List<VentasDtos> listaVentas)
        {
            int x = 0;
            Console.WriteLine("Dame la fecha en el siguiente formato por favor(dd/MM/yyyy), para calcular el importe del dia");
            DateTime fecha = Convert.ToDateTime(Console.ReadLine());

            foreach(VentasDtos ventasDtos in listaVentas)
            {
                if (fecha.Day == ventasDtos.FechaInstante.Day & fecha.Month == ventasDtos.FechaInstante.Month & fecha.Year == ventasDtos.FechaInstante.Year)
                {
                    x += ventasDtos.ImporteVenta;
                }
            }
            DateTime fechaInicial = listaVentas[0].FechaInstante;
            DateTime fechaFinal = listaVentas[listaVentas.Count - 1].FechaInstante;
            TimeSpan diferencias = fechaFinal-fechaInicial;
            Double segDecimales = diferencias.TotalSeconds;

            double minutosfake = (segDecimales / 60);
            int segundos = (int)(segDecimales % 60);
            int min = (int)(minutosfake % 60);
            int horas = (int) (minutosfake / 60);





            Console.WriteLine($"Total ventas: {x} euros\r\n" +
                $"Tiempo transcurrido:{horas} horas {min} minutos y {segundos} segundos\r\n");
           

        }
    }
}
