using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDequipo.Datos.Interfaz.Implementacion
{
    internal class DaoEquipo : IDaoEquipo
    {
        public int ObtenerProximo()
        {
            string sp_nombre = "sp_ObtenerProximo";
            string NombreOutPut = "@Next";
            return Helper.ObtenerInstancia().ObtenerProximo(sp_nombre,NombreOutPut);
        }
    }
}
