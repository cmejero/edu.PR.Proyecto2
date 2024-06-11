using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.PR.Proyecto2.Dtos
{
    internal class ClienteDto
    {


        long id;
        string nombre = "aaaaa";
        string apellidos = "aaaaa";
        string nombreCompleto = "aaaaa";
        string dni = "aaaaa";
        DateTime fechaNacimiento = new DateTime(1999, 1, 31);
        bool esValido = false;

        public ClienteDto(long id, string nombre, string apellidos, string dni, DateTime fechaNacimiento, bool esValido)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.nombreCompleto = String.Concat(nombre,apellidos);
            this.dni = dni;
            this.fechaNacimiento = fechaNacimiento;
            this.esValido = esValido;
        }

        public long Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }
        public string Dni { get => dni; set => dni = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public bool EsValido { get => esValido; set => esValido = value; }

        override

            public string ToString()
        {
            string fechaN= fechaNacimiento.ToString("dd-MM-yyyy");
            string esValidoS = Convert.ToString(esValido);

            string toString = String.Concat("nombreCompleto: ", nombreCompleto, " dni: ", dni, " fecha de nacimiento: ", fechaN, "es valido: ", esValidoS);

            return toString;



        }

        public ClienteDto()
        {
        }

        public string ToString(string caracter)
        {
            string fechaN = fechaNacimiento.ToString("dd-MM-yyyy");
            string esValidoS = Convert.ToString(esValido);

            string toString = String.Concat(nombre,caracter,apellidos,caracter, dni,caracter,fechaN,caracter,esValidoS);

            return toString;



        }
    }
}
