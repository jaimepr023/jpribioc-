using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jpribioExamen.Servicios
{
    /// <summary>
    /// Interfaz donde esta los metodos en relacion con el menu
    /// JPR-04/03/2024
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo que muestra el menu principal
        /// JPR-04/03/2024
        /// </summary>
        /// <returns>devuelve la opcion</returns>
        public int menuPrincipal();
        /// <summary>
        /// Metodo que muestra el menu empleado
        /// JPR-04/03/2024
        /// </summary>
        /// <returns>devuelve la opcion</returns>
        public int menuEmpelado();
        /// <summary>
        /// Metodo que muestra el menu proveedor
        /// JPR-04/03/2024
        /// </summary>
        /// <returns>devuelve la opcion</returns>
        public int menuProveedor();

    }
}
