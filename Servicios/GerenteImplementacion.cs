using jpribioExamen.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jpribioExamen.Servicios
{
    /// <summary>
    /// Clase que implementa la interfaz del gerente 
    /// JPR-04/03/2024
    /// </summary>
    internal class GerenteImplementacion : GerenteInterfaz
    {
        public void crearPedidosProveedores(List<ProductoDtos> listaProductos)
        {
            string afirmacion;
            do
            {
                int id = idAutonumerico(listaProductos);
                Console.WriteLine("Dame el nombre del producto");
                string nombre = Console.ReadLine();
                Console.WriteLine("Dame la cantidad del producto");
                int cantidad = int.Parse(Console.ReadLine());
                Console.WriteLine("Dame la fecha de entrega con el siguiente formato por favor(dd/MM/yyyy)");
                DateTime fecha = Convert.ToDateTime(Console.ReadLine());

                ProductoDtos producto = new ProductoDtos(id,nombre,cantidad,fecha);
                listaProductos.Add(producto);
                Console.WriteLine("¿Quieres volvera pedir un nuevo pedido?(s/n) ");
                afirmacion = Console.ReadLine();
            } while (afirmacion.Equals("s"));
            foreach(ProductoDtos producto in listaProductos)
            {
                Console.WriteLine(producto.ToString());
            }

        }
        /// <summary>
        /// Generador de id automatico 
        /// JPR-04/03/2024
        /// </summary>
        /// <param name="listaProductos">Lista de productos</param>
        /// <returns></returns>
        public int idAutonumerico(List<ProductoDtos> listaProductos)
        {
            int id;
            int tamañoLista = listaProductos.Count;

            if (tamañoLista <= 0)
            {
                id = 1;
            }
            else
            {
                id = listaProductos[tamañoLista - 1].Id + 1;
            }
            return id;
        }

        public void mostrarVentasDia(List<VentasDtos> listaVentas, string ficheroRuta)
        {
            Console.WriteLine("Dame una fecha para ver todas las ventas en el fichero, por favor que sea en el siguiente formato(dd/MM/yyyy)");
            DateTime fecha = Convert.ToDateTime(Console.ReadLine());
            using (StreamWriter sw = new StreamWriter(ficheroRuta))
            {
                foreach (VentasDtos ventasDtos in listaVentas)
                {
                    if (fecha.Day == ventasDtos.FechaInstante.Day & fecha.Month == ventasDtos.FechaInstante.Month & fecha.Year == ventasDtos.FechaInstante.Year)
                    {

                        sw.WriteLine($"-------------------------\r\n" +
                            $"Venta número: {ventasDtos.Id}\r\n" +
                            $"Euros: {ventasDtos.ImporteVenta} euros\r\n" +
                            $"Instante de compra: {ventasDtos.FechaInstante.ToString("dd/MM/yyyy HH:mm:ss")}\r\n" +
                            $"-------------------------\r\n");

                    }
                }
            }

        }
    }
}
