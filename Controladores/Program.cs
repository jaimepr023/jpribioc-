using jpribioExamen.Dtos;
using jpribioExamen.Servicios;

namespace jpribioExamen
{
    /// <summary>
    /// Clase donde se encuentra el metodo main
    /// JPR-04/03/2024
    /// </summary>
    class program
    {
        /// <summary>
        /// Metodo main donde se encuentra el procedimiento de nuestra aplicacion
        /// JPR-04/03/2024
        /// </summary>
        /// <param name="args"></param>
        public static void Main(String[] args) 
        {
            string rutaFichero = "C:\\Users\\profesor\\Desktop\\examen\\ddMMyyyy.txt";
            List<VentasDtos> listaVentas = new List<VentasDtos>();
            List<ProductoDtos> listaProductos = new List<ProductoDtos>();    
            MenuInterfaz mi = new MenuImplementacion();
            VentasInterfaz vt = new VentasImplementacion();
            GerenteInterfaz ge = new GerenteImplementacion();


            int opcionMenu, opcionMenu1, opcionMenu2;
            bool cerrarMenu = false;
            DateTime fecha1 = DateTime.Now;
            Console.WriteLine(fecha1.ToString());

            while(!cerrarMenu)
            {
                opcionMenu = mi.menuPrincipal();
                
                switch(opcionMenu)
                {
                    case 0:
                        cerrarMenu=true;
                        break;
                    case 1:
                        opcionMenu1 = mi.menuEmpelado();
                        switch (opcionMenu1)
                        {
                            case 0:
                                Console.WriteLine("A continuacion volveras al menu principal");
                                break;
                            case 1:
                                vt.agregarVenta(listaVentas);
                                break;
                            case 2:
                                vt.calculoDeVentasDiario(listaVentas);
                                break;
                            default:
                                Console.WriteLine("No ha eleigido ninguna opcion de las que se encuentra disponible, Volvera al menu principal");
                                break;
                        }
                        break;
                    case 2:
                        opcionMenu2 = mi.menuProveedor();
                        switch (opcionMenu2)
                        {
                            case 0:
                                Console.WriteLine("A continuacion volveras al menu principal");
                                break;
                            case 1:
                                ge.mostrarVentasDia(listaVentas, rutaFichero);
                                break;
                            case 2:
                                ge.crearPedidosProveedores(listaProductos);
                                break;
                            default:
                                Console.WriteLine("No ha eleigido ninguna opcion de las que se encuentra disponible, Volvera al menu principal");
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("No ha eleigido ninguna opcion de las que se encuentra disponible, intentelo de nuevo");
                        break;
                }
            }

        }
    }
}
