using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CRUDequipo.Dominio;

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

        public DataTable CargarCombo(string sp_nombre)
        {
            DataTable tb = new DataTable();
            cnn.Open();
            SqlCommand cmdCombo = new SqlCommand();
            cmdCombo.Connection=cnn;
            cmdCombo.CommandText = sp_nombre;
            cmdCombo.CommandType = CommandType.StoredProcedure;

            tb.Load(cmdCombo.ExecuteReader());
            cnn.Close();
            return tb;
        }

        public bool ConfirmarEquipo(Equipo oEquipo)
        {
            bool ok = true;
            SqlTransaction t = null;

            try
            {
                SqlCommand cmdMaestro = new SqlCommand();
                cnn.Open();
                t = cnn.BeginTransaction();

                cmdMaestro.Transaction = t;
                cmdMaestro.Connection = cnn;
                cmdMaestro.CommandText = "sp_Insert_Maestro";                
                cmdMaestro.CommandType = CommandType.StoredProcedure;

                cmdMaestro.Parameters.AddWithValue("@nombre", oEquipo.Nombre);
                cmdMaestro.Parameters.AddWithValue("@director_tecnico", oEquipo.DirectorTecnico);

                SqlParameter pOutPut = new SqlParameter();
                pOutPut.ParameterName = "@id_equipo";
                pOutPut.Direction = ParameterDirection.Output;
                pOutPut.DbType = DbType.Int32;

                cmdMaestro.Parameters.Add(pOutPut);

                cmdMaestro.ExecuteNonQuery();

                int id_equipo = (int)pOutPut.Value;

                foreach(Jugador j in oEquipo.LstJugadores)
                {
                    SqlCommand cmdDetalle = new SqlCommand();
                    cmdDetalle.Connection=cnn;
                    cmdDetalle.Transaction=t;
                    cmdDetalle.CommandText="sp_cargar_detalle";                    
                    cmdDetalle.CommandType= CommandType.StoredProcedure;

                    cmdDetalle.Parameters.AddWithValue("@id_persona", j.Persona.IdPersona);
                    cmdDetalle.Parameters.AddWithValue("@id_posicion", j.Tipo.IdTipoPosicion);
                    cmdDetalle.Parameters.AddWithValue("@camiseta", j.Camiseta);
                    cmdDetalle.Parameters.AddWithValue("@id_equipo",id_equipo);

                    cmdDetalle.ExecuteNonQuery();
                }
                t.Commit();
            }
            catch (Exception )
            {
                if(t != null)
                    t.Rollback();
                ok = false;
            }
            finally
            {
                if(cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            return ok;
        }
    }
}
