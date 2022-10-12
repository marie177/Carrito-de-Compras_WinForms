using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocio
{
    public class MarcaNegocio
    {
        AccesoDatos db = new AccesoDatos();

        public List<Marca> listar()
        {
            List<Marca> lista = new List<Marca>();

            string consulta = "Select M.Id, M.Descripcion From MARCAS M";

            try
            {
                db.SetearConsulta(consulta);
                db.EjecutarLectura();

                while (db.Reader.Read())
                {
                    Marca marca = new Marca();

                    marca.ID = db.Reader.GetInt32(0);
                    marca.Descripcion = db.Reader.GetString(1);

                    lista.Add(marca);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
            finally
            {
                db.CerrarConexion();
            }

            return lista;
        }

        public void AgregarMarca(Marca nueva)
        {
            try
            {
                db.SetearConsulta($"INSERT INTO MARCAS (Descripcion) VALUES ('{nueva.Descripcion}')");
                db.EjecutarAccion();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                db.CerrarConexion();
            }
        }


        public void ModificarMarca(Marca modificar)
        {
            try
            {
                db.SetearConsulta($"UPDATE MARCAS SET Descripcion = '{modificar.Descripcion}' WHERE ID = @id");
                db.SetearParametro("@id", modificar.ID);
                db.EjecutarAccion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                db.CerrarConexion();
            }
        }

        public void EliminarMarca(Marca eliminar)
        {
            try
            {
                db.SetearConsulta($"DELETE FROM MARCAS WHERE ID = {eliminar.ID}");
                db.EjecutarAccion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                db.CerrarConexion();
            }
        }
    }
}
