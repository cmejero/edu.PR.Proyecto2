using edu.PR.Proyecto2.Dtos;
using edu.PR.Proyecto2.Servicios;
using edu.PR.Proyecto2.Utiles;

namespace edu.PR.Proyecto2.Controladores
{
    internal class Program
    {

        public static string rutaFichero = "C:\\Users\\Carlo\\OneDrive\\Escritorio\\FICHEROS\\Proyecto2\\";
        public static string rutaFicheroCliente = "C:\\Users\\Carlo\\OneDrive\\Escritorio\\FICHEROS\\Proyecto2\\clientes.txt";        
        public static string rutaFicheroLog = String.Concat(rutaFichero,Util.nombreLog());
        public static List<ClienteDto> listaClientes = new List<ClienteDto>();


        static void Main(string[] args)
        {
            MenuInterfaz mi = new MenuImplemetnacion();
            FicherosInterfaz fi = new FicherosImplementacion();
            OperativaInterfaz oi = new OperacionImplementacion();

            fi.leerFichero();

           

            int opcionUsuario;
            bool cerrarMenu = false;

            do
            {
                try
                {

                    opcionUsuario = mi.menuYSeleccion();

                    switch (opcionUsuario)
                    {

                        case 0:
                            Console.WriteLine("Has seleccionado cerrar aplicacion");
                            fi.escribirFicheroLog("Has seleccionado cerrar aplicacion");
                            fi.escribirClientes();
                            cerrarMenu = true;
                            break;
                        case 1:
                            Console.WriteLine("Has seleccionado Modificar");
                            fi.escribirFicheroLog("Has seleccionado Modificar");
                            oi.modificar();
                            
                            break;
                        case 2:
                            Console.WriteLine("Has seleccionado Borrar");
                            fi.escribirFicheroLog("Has seleccionado Borrar");
                            oi.eliminar();  

                            break;
                        case 3:
                            Console.WriteLine("Has seleccionado Agregar");
                            fi.escribirFicheroLog("Has seleccionado Agregar");
                            oi.agregar();

                            break;
                        default:
                            Console.WriteLine("Has seleccionado una opcion incorrecta");
                            fi.escribirFicheroLog("Has seleccionado una opcion incorrecta");
                            break;




                    }
                }
                catch (Exception ex) {

                    Console.WriteLine("Se ha producido un error, intentelo más tarde");
                    fi.escribirFicheroLog("Se ha producido un error " +ex.Message);

                }


            } while (!cerrarMenu);






        }
    }
}
