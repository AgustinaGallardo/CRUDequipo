using CRUDequipo.Datos.Interfaz;
using CRUDequipo.Datos.Interfaz.Implementacion;
using CRUDequipo.Servicios.Intefaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDequipo.Servicios.Implementacion
{
    internal class Servicio : IServicio
    {
        private IDaoEquipo dao;

        public Servicio()
        {
            dao = new DaoEquipo();
        }
        public int ObtenerProximo()
        {
            return dao.ObtenerProximo();
        }
    }
}
