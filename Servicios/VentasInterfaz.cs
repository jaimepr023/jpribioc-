using jpribioExamen.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jpribioExamen.Servicios
{
    /// <summary>
    /// Interfaz que se encuentra los metodos en relacion a el empleado
    /// JPR-04/03/2024
    /// </summary>
    internal interface VentasInterfaz
    {
        /// <summary>
        /// Metodo que agrega una venta
        /// JPR-04/03/2024
        /// </summary>
        /// <param name="listaVentas">Lista de las ventas </param>
        public void agregarVenta(List<VentasDtos> listaVentas);

        /// <summary>
        /// Metodo que calcula las ventas totales de un dia
        /// JPR-04/03/2024
        /// </summary>
        /// <param name="listaVentas">Lista de ventas</param>
        public void calculoDeVentasDiario(List<VentasDtos> listaVentas);
    }
}
