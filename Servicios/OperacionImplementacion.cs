using edu.PR.Proyecto2.Controladores;
using edu.PR.Proyecto2.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace edu.PR.Proyecto2.Servicios
{
    internal class OperacionImplementacion : OperativaInterfaz
    {
        MenuInterfaz mi = new MenuImplemetnacion();
        FicherosInterfaz fi = new FicherosImplementacion();

        public void modificar()
        {
            int opcionUsuario;
           


            foreach (ClienteDto clienteDto in Program.listaClientes)
            {
                Console.WriteLine(clienteDto.ToString(";"));
            }
            Console.WriteLine(Program.listaClientes.Count);

            

            Console.WriteLine("introduzca el Dni");
            string dniUsu = Console.ReadLine();
            bool coincide = false;
            bool volver = false;

            do
            {
                try
                {
                    foreach (ClienteDto cliente in Program.listaClientes)
                    {
                        if (cliente.Dni.Equals(dniUsu))
                        {
                            coincide = true;
                            opcionUsuario = mi.menuYSeleccionModificar();

                            switch (opcionUsuario)
                            {
                                case 0:
                                    Console.WriteLine("Has seleccionado volver");
                                    volver = true;
                                    break;

                                case 1:
                                    Console.WriteLine("Introduzca el nuevo nombre");
                                    cliente.Nombre = Console.ReadLine();
                                    
                                    break;

                                case 2:
                                    Console.WriteLine("Introduzca el nuevo apellidos");
                                    string apellidos = Console.ReadLine();
                                    cliente.Apellidos = apellidos;
                                    break;

                                case 3:
                                    Console.WriteLine("Introduzca el numero de dias a agregar");
                                    int numero = Convert.ToInt32(Console.ReadLine());
                                    DateTime nuevaFecha = cliente.FechaNacimiento;
                                    Console.WriteLine(nuevaFecha.ToString());
                                    nuevaFecha = nuevaFecha.AddDays(numero);
                                    Console.WriteLine(nuevaFecha.ToString());
                                    cliente.FechaNacimiento = nuevaFecha;


                                    break;
                                case 4:
                                    Console.WriteLine("Introduzca si es valido: s/n");
                                    string respuestaValido = Console.ReadLine();
                                    if (respuestaValido.Equals("s"))
                                    {
                                        cliente.EsValido = true;
                                    }
                                    else if (respuestaValido.Equals("n")) { 
                                    cliente.EsValido = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("No has introducido \"s\" o \"n\" ");
                                    }

                                    break;

                                default:
                                    Console.WriteLine("La opcion introducida no es valida");
                                    break;
                            }
                            

                        }





                    }

                    

                }
                catch(Exception ex) 
                
                { Console.WriteLine("Se ha producido un error, intentelo más tarde");
                    fi.escribirFicheroLog("Se ha producido un error" +  ex.Message);
                }

            } while (!volver);

            if (coincide == false)
            {
                Console.WriteLine("El dni no corresponde con ninguno");
            }

        }

        public void eliminar()
        {
            Console.WriteLine("Introduzca el dni para eliminar");
            string dniUs = Console.ReadLine();
            bool coincide = false;
            ClienteDto aux = new ClienteDto();

            foreach (ClienteDto cliente in Program.listaClientes)
            {
                if (cliente.Dni.Equals(dniUs))
                {
                    aux = cliente;
                    coincide = true;
                    break;
                }


            }
            if (coincide == true)
            {
                Program.listaClientes.Remove(aux);
            }
            else


            {
                Console.WriteLine("El dni no coincide con niguno");
            }
        }

        public void agregar() {

            ClienteDto cliente = new ClienteDto();

            cliente.Id = crearId();
            Console.WriteLine("Introduzca el nombre");
            cliente.Nombre = Console.ReadLine();
            Console.WriteLine("Introduzca los apellidos");
            cliente.Apellidos = Console.ReadLine();
            Console.WriteLine("Introduzca el dni");
            cliente.Dni = Console.ReadLine();
            Console.WriteLine("Introduzca la fecha De Nacimiento");
            string fecha = Console.ReadLine();
            DateTime fechaNac = DateTime.Parse(fecha);
            cliente.FechaNacimiento = fechaNac;
            Console.WriteLine("Introduzca si es valido");
            string valido = Console.ReadLine();
            bool esValido = bool.Parse(valido);
            cliente.EsValido = esValido;

            Program.listaClientes.Add(cliente);

        }

        private long crearId()
        {
            long nuevoId;
            int tamanioLista = Program.listaClientes.Count;
            if(tamanioLista > 0)
            {
                nuevoId = Program.listaClientes[tamanioLista - 1].Id + 1;
            }
            else
            {
                nuevoId = 1;
            }
            return nuevoId;
        }
    }
}
