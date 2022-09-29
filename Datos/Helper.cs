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

        public static Helper ObtenerInstancia()
        {
            if(instancia == null)
                instancia = new Helper();
            return instancia;
        }

        public int ObtenerProximo(string sp_nombre,string OutPut)
        {
            cnn.Open();
            SqlCommand cmdNext = new SqlCommand();

            cmdNext.Connection = cnn;
            cmdNext.CommandText = sp_nombre;
            cmdNext.CommandType=CommandType.StoredProcedure;

            SqlParameter pOutPut  = new SqlParameter();
            pOutPut.ParameterName = OutPut;
            pOutPut.Direction = ParameterDirection.Output;
            pOutPut.DbType = DbType.Int32;

            cmdNext.Parameters.Add(pOutPut);
            cmdNext.ExecuteReader();
            cnn.Close();
            return (int)pOutPut.Value;
        }
    }
}
