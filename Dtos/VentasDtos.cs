using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jpribioExamen.Dtos
{
    /// <summary>
    /// Clase donde se encuentra los atributos de las ventas
    /// JPR-04/03/2024
    /// </summary>
    internal class VentasDtos
    {
        int id;
        int importeVenta = 0;
        DateTime fechaInstante = DateTime.Now;
        DateTime fechaAhora = DateTime.Today;
        

        public int Id { get => id; set => id = value; }
        public int ImporteVenta { get => importeVenta; set => importeVenta = value; }
        public DateTime FechaInstante { get => fechaInstante; set => fechaInstante = value; }

        public VentasDtos(int id, int importeVenta)
        {
            this.id = id;
            this.importeVenta = importeVenta;
            this.fechaInstante = fechaInstante;
        }

        public VentasDtos()
        {
        }
    }
}
