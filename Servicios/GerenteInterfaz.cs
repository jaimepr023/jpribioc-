using jpribioExamen.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jpribioExamen.Servicios
{
    /// <summary>
    /// Interfaz donde se encuentra la cabecera de los metodos del gerente 
    /// JPR-04/03/2024
    /// </summary>
    internal interface GerenteInterfaz
    {
        /// <summary>
        /// Cabecera del metodo de mostrar las ventas del dia en el fichero
        /// JPR-04/03/2024
        /// </summary>
        /// <param name="listaVentas">Lista de las ventas</param>
        /// <param name="ficheroRuta">ruta del fichero log</param>
        public void mostrarVentasDia(List<VentasDtos> listaVentas, string ficheroRuta);

        /// <summary>
        /// Metodo de crear un pedido para los proveedores 
        /// JPR-04/03/2024
        /// </summary>
        /// <param name="listaProductos">Lista de los productos/pedidos</param>
        public void crearPedidosProveedores(List<ProductoDtos> listaProductos);
    }
}
