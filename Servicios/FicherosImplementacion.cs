using edu.PR.Proyecto2.Controladores;
using edu.PR.Proyecto2.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.PR.Proyecto2.Servicios
{

    /// <summary>
    /// clase que implementa al fichero interfaz
    /// </summary>
    internal class FicherosImplementacion : FicherosInterfaz
    {
        public void escribirFicheroLog(string mensaje)
        {

            StreamWriter st = null;
            try
            {

                st = new StreamWriter(Program.rutaFicheroLog, true);

                st.WriteLine(mensaje);




            }
            catch (IOException io)
            {
                Console.WriteLine("Se ha producido un error, intentelo de mas tarde");

            }
            finally
            {

                if (st != null)
                {
                    st.Close();
                }
            }

        }

        public void leerFichero()
        {

            StreamReader sr = null;

            try
            {

                sr = new StreamReader(Program.rutaFicheroCliente);

                string lineas = "";

                while ((lineas = sr.ReadLine()) != null)
                {

                    string[] linea = lineas.Split(";");

                    

                    long id = crearId();
                    string nombre = linea[0].Trim();
                    string apellido = linea[1].Trim();
                    string dni = linea[2].Trim();
                    string fecha = linea[3].Trim();
                    DateTime fechaN = DateTime.Parse(fecha);
                    string esValidoString = linea[4].Trim();
                    bool esValidoB = bool.Parse(esValidoString);

                   


                    ClienteDto cliente = new ClienteDto(id,nombre,apellido,dni,fechaN,esValidoB);

                    Program.listaClientes.Add(cliente);

                }


            }
            catch (IOException io)
            {
                escribirFicheroLog("Se ha porducido un error: " + io.Message);
                Console.WriteLine("Se ha producido un error, intentelo más tarde");

            }
            finally
            {
                if(sr != null)
                {

                sr.Close(); }

            }
        }

        public void escribirClientes()
        {
            StreamWriter st = null;
            

            try
            {


                st = new StreamWriter(Program.rutaFicheroCliente);

                foreach (ClienteDto cliente in Program.listaClientes)
                {

                    st.WriteLine(cliente.ToString(";"));

                }




            }
            catch (IOException io)
            {
                escribirFicheroLog("Se ha producido un error en escribir clientes en fichero: " + io.Message);
            }
            finally
            {

                if (st != null)
                { st.Close(); }

            }



        }


        private long crearId()
        {

            long nuevoId;
            int tamanioLista = Program.listaClientes.Count;

            if (tamanioLista > 0) {

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
