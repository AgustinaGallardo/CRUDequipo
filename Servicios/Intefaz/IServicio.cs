using CRUDequipo.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDequipo.Servicios.Intefaz
{
    internal interface IServicio
    {
        int ObtenerProximo();

        List<Persona> ObtenerPersonas();
        List<TipoPosicion> ObtenerTipos();
    }
}
