using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.PR.Proyecto2.Servicios
{

    /// <summary>
    /// Clase que se encarga de los metodos relacionados con los ficheros
    /// </summary>
    internal interface FicherosInterfaz
    {

        public void escribirFicheroLog(string mensaje);


        public void leerFichero();
        public void escribirClientes();
    }
}
