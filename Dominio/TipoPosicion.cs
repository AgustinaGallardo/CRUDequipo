using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDequipo.Dominio
{
    internal class TipoPosicion
    {
        public int IdTipoPosicion { get; set; } 
        public string NombreTipo { get; set; }

        public TipoPosicion()
        {
            IdTipoPosicion = 0;
            NombreTipo = string.Empty;
        }
        public TipoPosicion(int id,string nombre)
        {
            IdTipoPosicion = id;
            NombreTipo = nombre;
        }
        public override string ToString()
        {
            return NombreTipo;
        }
    }
}
