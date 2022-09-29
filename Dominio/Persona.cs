using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDequipo.Dominio
{
     class Persona
    {
        public string NombreCompleto { get; set; }
        public int Dni { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public Persona()
        {
            NombreCompleto = string.Empty;
            Dni = 0;
            FechaNacimiento = DateTime.Now;
        }
        public Persona(string nombre,int dni,DateTime fecha)
        {
            NombreCompleto = nombre;    
            Dni = dni;
            FechaNacimiento=fecha;
        }
        public override string ToString()
        {
            return NombreCompleto;
        }
    }
}
