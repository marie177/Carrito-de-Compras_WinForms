using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Negocio
{
    public class AccesoDatos
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;
        public SqlDataReader Reader { get { return reader; } }
   
        public AccesoDatos()
        {
            connection = new SqlConnection("server=.; database=CATALOGO_DB; Integrated Security=true;");
            command = new SqlCommand();
        }

        public void SetearConsulta(string consulta)
        {
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = consulta;
        }

        public void EjecutarLectura()
        {
            command.Connection = connection;

            try
            {
                connection.Open();
                reader = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void EjecutarAccion()
        {
            command.Connection = connection;

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        public void SetearParametro(string p, object value)
        {
            command.Parameters.AddWithValue(p, value);
        }


        public void CerrarConexion()
        {
            if (reader != null) reader.Close();

            connection.Close();
        }
    }
}
