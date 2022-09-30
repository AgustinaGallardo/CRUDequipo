using CRUDequipo.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDequipo.Datos.Interfaz.Implementacion
{
    internal class DaoEquipo : IDaoEquipo
    {
       
        public List<Persona> ObtenerPersonas()
        {
            List<Persona> personas = new List<Persona>();
            string sp_nombre = "sp_CARGAR_PERSONAS";

            DataTable tb = Helper.ObtenerInstancia().CargarCombo(sp_nombre);

            foreach (DataRow dr in tb.Rows)
            {
                int id = int.Parse(dr["id_persona"].ToString());
                string nombre = dr["nombre_completo"].ToString();
                Persona p = new Persona(id, nombre);
                personas.Add(p);
            }
            return personas;
        }

        public int ObtenerProximo()
        {
            string sp_nombre = "sp_ObtenerProximo";
            string NombreOutPut = "@Next";
            return Helper.ObtenerInstancia().ObtenerProximo(sp_nombre,NombreOutPut);
        }

        public List<TipoPosicion> ObtenerTipos()
        {
            List<TipoPosicion> lst = new List<TipoPosicion>();
            string sp_nombre = "sp_cargar_posiciones";
            DataTable tb = Helper.ObtenerInstancia().CargarCombo(sp_nombre);

            foreach(DataRow dr in tb.Rows)
            {
                int id = int.Parse(dr["id_posicion"].ToString());
                string nombre = dr["nombre_posicion"].ToString();
                TipoPosicion tp = new TipoPosicion(id, nombre);
                lst.Add(tp);
            }
            return lst;
        }
    }
}
