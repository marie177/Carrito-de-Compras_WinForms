using Dominio;
using Negocio;
using System.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace TPWinForm_Gottig_Ramirez
{

    public partial class frmAgregarArt : Form
    {
        private Articulo articulo = null;
        private OpenFileDialog archivo = null;

        public frmAgregarArt()
        {
            InitializeComponent();
        }

        public frmAgregarArt(Articulo art)
        {
            InitializeComponent();
            this.articulo = art;
            this.lblTituloAgregar.Text = $"Modificar articulo #{this.articulo.Codigo}";
            Text = "Modificar Articulo";
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool validarCampos()
        {
            bool flag = true;

            if (string.IsNullOrEmpty(tbxCodigo.Text))
            {
                lblCodIncorrecto.Visible = true;
                flag = false;
            }
            else
            {
                lblCodIncorrecto.Visible = false;
            }

            if (string.IsNullOrEmpty(tbxNombre.Text))
            {
                lblNombreInvalido.Visible = true;
                flag = false;
            }
            else 
            {
                lblNombreInvalido.Visible = false;
            }
          

            if(string.IsNullOrEmpty(tbxPrecio.Text))
            {
                lblPrecioInvalido.Visible = true;
                flag = false;
            }
            else
            {
                lblPrecioInvalido.Visible = false;
            }

            return flag;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            ArticuloNegocio articuloNegocio = new ArticuloNegocio();

            try
            {
                if (articulo == null)
                    articulo = new Articulo();

                if(!validarCampos())
                {
                    return;
                }

                articulo.Codigo = tbxCodigo.Text;
                articulo.Nombre = tbxNombre.Text;
                articulo.Descripcion = tbxDesc.Text;

                articulo.Marca = new Marca();
                articulo.Marca = (Marca)cbxMarcas.SelectedItem;

                articulo.Categoria = new Categoria();
                articulo.Categoria = (Categoria)cbxCategoria.SelectedItem;

                articulo.ImagenUrl = tbxImagenUrl.Text;
                articulo.Precio = float.Parse(tbxPrecio.Text);

                if (archivo != null && !(tbxImagenUrl.Text.ToLower().Contains("http")))
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["carpeta-imagenes"] + archivo.SafeFileName, true);

                if (articulo.Id != 0)
                {
                    articuloNegocio.ModificarArticulo(articulo);
                    MessageBox.Show("Articulo modificado exitosamente!");
                }
                else
                {
                    articuloNegocio.AgregarArticulo(articulo);
                    MessageBox.Show("Articulo agregado exitosamente!");
                }

                this.Close();
            }
            catch (FormatException)
            {
                lblPrecioInvalido.Visible = true;
                lblPrecioInvalido.Text = "* Solo números por favor";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }

        }

        private void frmAgregarArt_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio catNegocio = new CategoriaNegocio();

            try
            {
                cbxMarcas.DataSource = marcaNegocio.listar();
                cbxMarcas.ValueMember = "ID";
                cbxMarcas.DisplayMember = "Descripcion";


                cbxCategoria.DataSource = catNegocio.listar();
                cbxCategoria.ValueMember = "ID";
                cbxCategoria.DisplayMember = "Descripcion";

                if (articulo != null)
                {
                    tbxCodigo.Text = articulo.Codigo;
                    tbxNombre.Text = articulo.Nombre;
                    tbxDesc.Text = articulo.Descripcion;

                    //falta arreglar 
                    if(articulo.Categoria!= null)
                    cbxCategoria.SelectedValue = articulo.Categoria.ID;

                    if(articulo.Marca != null)
                    cbxMarcas.SelectedValue = articulo.Marca.ID;

                    tbxImagenUrl.Text = articulo.ImagenUrl;
                    //img tiene que ir fixed al recuadro
                    cargarImagen(articulo.ImagenUrl);

                    tbxPrecio.Text = articulo.Precio.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void cargarImagen(string img)
        {
            try
            {
                pictureBox1.Load(img);
            }
            catch (Exception)
            {
                pictureBox1.Load("https://budmil.at/files/system/no_image.png");
            }
        }

        private void tbxImagenUrl_Leave(object sender, EventArgs e)
        {
            cargarImagen(tbxImagenUrl.Text);
        }

        private void btnCargarImg_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();

            archivo.Filter = "jpg|*.jpg|png|*.png";

            if (archivo.ShowDialog() == DialogResult.OK)
            {
                tbxImagenUrl.Text = archivo.FileName;
                cargarImagen(archivo.FileName);
            }
        }
    }
}
