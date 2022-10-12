using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocio
{
    public class CategoriaNegocio
    {
        private AccesoDatos db = new AccesoDatos();

        public List<Categoria> listar()
        {
            List<Categoria> lista = new List<Categoria>();

            string consulta = "Select C.Id, C.Descripcion From CATEGORIAS C";

            db.SetearConsulta(consulta);
            db.EjecutarLectura();

            try 
            {
                while (db.Reader.Read())
                {
                    Categoria cat = new Categoria();

                    cat.ID = db.Reader.GetInt32(0);
                    cat.Descripcion = db.Reader.GetString(1);

                    lista.Add(cat);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                db.CerrarConexion();
            }

            return lista;
        }

        public void AgregarCategoria(Categoria nueva)
        {
            try
            {
                string accion = $"INSERT INTO CATEGORIAS (Descripcion) VALUES ('{nueva.Descripcion}')";

                db.SetearConsulta(accion);
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

        public void ModificarCategoria(Categoria modificar)
        {
            try
            {
                string accion = $"UPDATE CATEGORIAS SET DESCRIPCION = '{modificar.Descripcion}' WHERE ID = {modificar.ID} ";
                db.SetearConsulta(accion);
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

        public void EliminarCategoria(Categoria eliminar)
        {
            try
            {
                string accion = $"DELETE FROM CATEGORIAS WHERE ID = {eliminar.ID}";

                db.SetearConsulta(accion);
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
