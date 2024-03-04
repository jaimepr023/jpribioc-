using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jpribioExamen.Dtos
{
    /// <summary>
    /// Clase donde se encuentra los atributos de la parte de pedidos/productos
    /// JPR-04/03/2024
    /// </summary>
    internal class ProductoDtos
    {
        int id;
        string nombreProducto = "aaaaa";
        int cantidadProducto = 0;
        DateTime fecha = new DateTime();

        public int Id { get => id; set => id = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public int CantidadProducto { get => cantidadProducto; set => cantidadProducto = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }

        public ProductoDtos()
        {
        }

        public ProductoDtos(int id, string nombreProducto, int cantidadProducto, DateTime fecha)
        {
            this.id = id;
            this.nombreProducto = nombreProducto;
            this.cantidadProducto = cantidadProducto;
            this.fecha = fecha;
        }

        override 
         public string ToString()
        {
            return 
                $"Producto: {nombreProducto}\r\n" +
                $"Cantidad: {cantidadProducto} unidades\r\n" +
                $"Fecha entrega: {fecha}\r\n";
        }
    }
}
