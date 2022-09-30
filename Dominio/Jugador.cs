using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDequipo.Dominio
{
     class Jugador : Persona
    {
        public Persona Persona { get; set; }        
        public string Camiseta { get; set; }
        public TipoPosicion Tipo { get; set; }
        public Jugador()
        {
            Persona = new Persona();            
            Camiseta = string.Empty;
            Tipo = new TipoPosicion();
        }
        public Jugador(Persona per,TipoPosicion tipo,string cam)
        {
            Persona = per;
            Camiseta = cam;
            Tipo = tipo;
        }

        public override string ToString()
        {
            return Camiseta;
        }

    }
}
