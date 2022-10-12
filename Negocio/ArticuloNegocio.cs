using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace Negocio
{
    public class ArticuloNegocio
    {
        private AccesoDatos db = new AccesoDatos();

        public List<Articulo> ListarArticulos()
        {
            List<Articulo> articulos = new List<Articulo>();
            string consulta = "SELECT A.ID AS ID, A.CODIGO AS CODIGO, A.NOMBRE AS NOMBRE, A.DESCRIPCION AS DESCRIPCION, M.ID AS IdMarca,M.Descripcion AS MARCA, C.ID AS IdCategoria, C.Descripcion AS CATEGORIA, A.IMAGENURL AS IMAGENURL, A.Precio AS PRECIO FROM ARTICULOS A LEFT JOIN MARCAS M ON A.IdMarca = M.Id LEFT JOIN CATEGORIAS C ON A.IdCategoria = C.Id";

            db.SetearConsulta(consulta);
            db.EjecutarLectura();

            try
            {
                while (db.Reader.Read())
                {
                    Articulo articulo = new Articulo();

                    articulo.Id = (int)db.Reader["ID"];

                    if (!(db.Reader["Codigo"] is DBNull))
                        articulo.Codigo = (string)db.Reader["Codigo"];

                    if (!(db.Reader["Nombre"] is DBNull))
                        articulo.Nombre = (string)db.Reader["Nombre"];

                    if (!(db.Reader["Descripcion"] is DBNull))
                        articulo.Descripcion = (string)db.Reader["Descripcion"];

                    articulo.Marca = new Marca();

                    if (!(db.Reader["MARCA"] is DBNull))
                    {
                        articulo.Marca.ID = (int)db.Reader["IdMarca"];
                        articulo.Marca.Descripcion = (string)db.Reader["Marca"];
                    }

                    if (!(db.Reader["CATEGORIA"] is DBNull))
                    {
                        articulo.Categoria = new Categoria();
                        articulo.Categoria.ID = (int)db.Reader["IdCategoria"];
                        articulo.Categoria.Descripcion = (string)db.Reader["Categoria"];
                    }

                    if (!(db.Reader["ImagenUrl"] is DBNull))
                        articulo.ImagenUrl = (string)db.Reader["ImagenUrl"];

                    if (!(db.Reader["Precio"] is DBNull))
                        articulo.Precio = (float)db.Reader.GetDecimal(9);

                    articulos.Add(articulo);
                }

                return articulos;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw ex;
            }
            finally
            {
                db.CerrarConexion();
            }

        }

        public void AgregarArticulo(Articulo nuevo)
        {
            try
            {

                string Consulta = $"Insert Into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) Values ('{nuevo.Codigo}', '{nuevo.Nombre}', '{nuevo.Descripcion}', @IdMarca, @IdCategoria, '{nuevo.ImagenUrl}',  {nuevo.Precio})";

                db.SetearParametro("@IdMarca", nuevo.Marca.ID);
                db.SetearParametro("@IdCategoria", nuevo.Categoria.ID);

                db.SetearConsulta(Consulta);
                db.EjecutarAccion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw ex;
            }
            finally
            {
                db.CerrarConexion();
            }
        }

        public void EliminarArticulo(Articulo AEliminar)
        {
            string Accion = $"Delete From ARTICULOS Where ARTICULOS.Id = {AEliminar.Id}";

            try
            {
                db.SetearConsulta(Accion);
                db.EjecutarAccion();

                MessageBox.Show($"Articulo {AEliminar.Codigo} eliminado!!");
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
        }

        public void ModificarArticulo(Articulo articulo)
        {
            try
            {
                string consulta = $"UPDATE ARTICULOS SET CODIGO = '{articulo.Codigo}', NOMBRE = '{articulo.Nombre}', Descripcion ='{articulo.Descripcion}', IdMarca=@IdMarca, IdCategoria=@IdCategoria, ImagenUrl = '{articulo.ImagenUrl}', PRECIO = {articulo.Precio} WHERE ID = {articulo.Id}";

                db.SetearConsulta(consulta);
                db.SetearParametro("@IdMarca", articulo.Marca.ID);
                db.SetearParametro("@IdCategoria", articulo.Categoria.ID);

                db.EjecutarAccion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw ex;
            }
            finally
            {
                db.CerrarConexion();
            }
        }

        private List<Articulo> ordenarLista(ref List<Articulo> lista, string campo, int ordenacion)
        {

            switch (ordenacion)
            {
                case 2:
                    switch (campo)
                    {
                        case "Código":
                            lista = lista.OrderBy(x => x.Codigo).ToList();
                            break;
                        case "Nombre":
                            lista = lista.OrderBy(x => x.Nombre).ToList();
                            break;
                        case "Marca":
                            lista = lista.OrderBy(x => x.Marca.Descripcion).ToList();
                            break;
                        case "Categoría":
                            lista = lista.OrderBy(x => x.Categoria.Descripcion).ToList();
                            break;
                        case "Precio":
                            lista = lista.OrderBy(x => x.Precio).ToList();
                            break;
                        default:
                            break;
                    }
                    break;
                case 1:
                    switch (campo)
                    {
                        case "Código":
                            lista = lista.OrderByDescending(x => x.Codigo).ToList();
                            break;
                        case "Nombre":
                            lista = lista.OrderByDescending(x => x.Nombre).ToList();
                            break;
                        case "Marca":
                            lista = lista.OrderByDescending(x => x.Marca.Descripcion).ToList();
                            break;
                        case "Categoría":
                            lista = lista.OrderByDescending(x => x.Categoria.Descripcion).ToList();
                            break;
                        case "Precio":
                            lista = lista.OrderByDescending(x => x.Precio).ToList();
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }

            return lista;
        }

        public List<Articulo> Filtrar(string campo, string criterio, string filtro, int ordenacion, int inicio, int fin)
        {
            List<Articulo> lista = new List<Articulo>();

            try
            {
                string consulta = "SELECT A.ID AS ID, A.CODIGO AS CODIGO, A.NOMBRE AS NOMBRE, A.DESCRIPCION AS DESCRIPCION, M.ID AS IdMarca,M.Descripcion AS MARCA, C.ID AS IdCategoria, C.Descripcion AS CATEGORIA, A.IMAGENURL AS IMAGENURL, A.Precio AS PRECIO FROM ARTICULOS A LEFT JOIN MARCAS M ON A.IdMarca = M.Id LEFT JOIN CATEGORIAS C ON A.IdCategoria = C.Id Where ";

                //Se agrega el where en string de consulta segun criterios y campo
                consulta = AddWhereConsulta(consulta, campo, criterio, filtro, inicio, fin);

                // Recibe la lista por referencia, se mapea el reader y devuelve la lista ya cargada
                lecturaFromDB(ref lista, consulta);

                // Recibe la lista por referencia y la ordena segun el campo y id de "ordenacion"(Asc/Desc)
                ordenarLista(ref lista, campo, ordenacion);

            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message);
                throw;
            }
            return lista;

        }

        public List<Articulo> lecturaFromDB(ref List<Articulo> lista, string consulta)
        {
            try
            {
                db.SetearConsulta(consulta);
                db.EjecutarLectura();

                while (db.Reader.Read())
                {
                    Articulo articulo = new Articulo();

                    articulo.Id = (int)db.Reader["ID"];

                    if (!(db.Reader["Codigo"] is DBNull))
                        articulo.Codigo = (string)db.Reader["Codigo"];

                    if (!(db.Reader["Nombre"] is DBNull))
                        articulo.Nombre = (string)db.Reader["Nombre"];

                    if (!(db.Reader["Descripcion"] is DBNull))
                        articulo.Descripcion = (string)db.Reader["Descripcion"];


                    if (!(db.Reader["MARCA"] is DBNull))
                    {
                        articulo.Marca = new Marca();
                        articulo.Marca.ID = (int)db.Reader["IdMarca"];
                        articulo.Marca.Descripcion = (string)db.Reader["Marca"];
                    }

                    if (!(db.Reader["CATEGORIA"] is DBNull))
                    {
                        articulo.Categoria = new Categoria();
                        articulo.Categoria.ID = (int)db.Reader["IdCategoria"];
                        articulo.Categoria.Descripcion = (string)db.Reader["Categoria"];
                    }

                    if (!(db.Reader["ImagenUrl"] is DBNull))
                        articulo.ImagenUrl = (string)db.Reader["ImagenUrl"];

                    if (!(db.Reader["Precio"] is DBNull))
                        articulo.Precio = (float)db.Reader.GetDecimal(9);

                    lista.Add(articulo);
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

        public string AddWhereConsulta(string consulta, string campo, string criterio, string filtro, int inicio, int fin)
        {

            switch (campo)
            {
                case "Código":
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += $"A.Codigo like '{filtro}%'";
                            break;
                        case "Contiene":
                            consulta += $"A.Codigo like '%{filtro}%'";
                            break;
                        case "Finaliza con":
                            consulta += $"A.Codigo like '%{filtro}'";
                            break;
                        default:
                            break;
                    }
                    break;
                case "Nombre":
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += $"A.Nombre like '{filtro}%'";
                            break;
                        case "Contiene":
                            consulta += $"A.Nombre like '%{filtro}%'";
                            break;
                        case "Finaliza con":
                            consulta += $"A.Nombre like '%{filtro}'";
                            break;
                        default:
                            break;
                    }
                    break;
                case "Marca":
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += $"M.Descripcion like '{filtro}%'";
                            break;
                        case "Contiene":
                            consulta += $"M.Descripcion like '%{filtro}%'";
                            break;
                        case "Finaliza con":
                            consulta += $"M.Descripcion like '%{filtro}'";
                            break;
                        default:
                            break;
                    }
                    break;
                case "Categoría":
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += $"C.Descripcion like '{filtro}%'";
                            break;
                        case "Contiene":
                            consulta += $"C.Descripcion like '%{filtro}%'";
                            break;
                        case "Finaliza con":
                            consulta += $"C.Descripcion like '%{filtro}'";
                            break;
                        default:
                            break;
                    }
                    break;
                case "Precio":
                    switch (criterio)
                    {
                        case "Menor a":
                            consulta += $"A.Precio < {filtro}";
                            break;
                        case "Entre valores":
                            consulta += $"A.Precio Between {inicio} And {fin}";
                            break;
                        case "Mayor a":
                            consulta += $"A.Precio > {filtro}";
                            break;
                        default:
                            break;
                    }
                    break;
            }

            return consulta;
        }

    }
}

