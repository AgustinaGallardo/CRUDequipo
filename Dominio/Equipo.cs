using System.Collections.Generic;

namespace CRUDequipo.Dominio
{
    internal class Equipo
    {
        public string Nombre { get; set; }
        public string DirectorTecnico { get; set; }
        public List<Jugador> LstJugadores { get; set; }
        public TipoPosicion Tipo { get; set; }
        public Equipo()
        {
            Nombre = string.Empty;
            DirectorTecnico = string.Empty;
            List<Jugador> lstJugadores = new List<Jugador>();
            Tipo = new TipoPosicion();
        }
        public Equipo(string nombre, string director, List<Jugador> jugadores,TipoPosicion tipo)
        {            
            Nombre = nombre;
            DirectorTecnico = director;
            List<Jugador> lstJugadores = jugadores;
            Tipo = tipo;
        }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
