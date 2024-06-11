using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.PR.Proyecto2.Servicios
{
    internal class MenuImplemetnacion : MenuInterfaz
    {
        public int menuYSeleccion() {

            int opcionUsuario;

            Console.WriteLine("######################");
            Console.WriteLine("0.Cerrar aplicacion");
            Console.WriteLine("1. Modificar");
            Console.WriteLine("2. Borrar");
            Console.WriteLine("3. Agregar");
            Console.WriteLine("######################");

            opcionUsuario = Convert.ToInt32(Console.ReadLine());
            return opcionUsuario;
        }

        public int menuYSeleccionModificar()
        {

            int opcionUsuario;

            Console.WriteLine("######################");
            Console.WriteLine("0. Volver");
            Console.WriteLine("1. Nombre");
            Console.WriteLine("2. apellidos");
            Console.WriteLine("3. fecha nacimiento");
            Console.WriteLine("4. es Valido");
            Console.WriteLine("######################");

            opcionUsuario = Convert.ToInt32(Console.ReadLine());
            return opcionUsuario;
        }


    }
}
