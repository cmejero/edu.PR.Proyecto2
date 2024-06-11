using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.PR.Proyecto2.Utiles
{

    /// <summary>
    /// Clase donde estan los metodos que se usaran más de una vez
    /// </summary>
    internal static class Util
    {
        /// <summary>
        /// Metodo que se encarga de crear el nombre del fichero log
        /// </summary>
        /// <returns></returns>
        public static string nombreLog()
        {
            string nombreRuta = "";
            try
            {

                DateTime fecha = DateTime.Today;
                string fechaString = fecha.ToString("ddMMyyyy");

                nombreRuta = String.Concat("log-", fechaString, ".txt");


            }
            catch (Exception e)
            {

            }


            return nombreRuta;
        }    
    }
}
