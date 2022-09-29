using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CRUDequipo.Datos
{
     class Helper
    {
        SqlConnection cnn = new SqlConnection(Properties.Resources.cnnCRUDequipo);
        private static Helper instancia;

        public Helper  ObtenerInstancia()
        {
            if(instancia == null)
                instancia = new Helper();
            return instancia;
        }
    }
}
