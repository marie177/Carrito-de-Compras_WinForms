using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace TPWinForm_Gottig_Ramirez
{
    public partial class frmAgregarCategoria : Form
    {
        private Categoria categoria = null;
        private CategoriaNegocio negocio = new CategoriaNegocio();

        public frmAgregarCategoria()
        {
            InitializeComponent();
        }

        public frmAgregarCategoria(Categoria categoria)
        {
            this.categoria = categoria;

            InitializeComponent();

        }
        private void frmAgregarCategoria_Load(object sender, EventArgs e)
        {
            if (categoria != null)
            {
                lblCategorias.Text = $"Categoria: {categoria.Descripcion}";
                btnAgregar.Text = "Modificar categoria";
                tbxDescripcion.Text = categoria.Descripcion;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (categoria == null) categoria = new Categoria();
                categoria.Descripcion = tbxDescripcion.Text;

                if (!validar()) return;

                if(categoria.ID != 0)
                {
                    negocio.ModificarCategoria(categoria);
                    MessageBox.Show("Categoria modificada exitosamente!");
                }
                else
                {
                    negocio.AgregarCategoria(categoria);
                    MessageBox.Show("Categoria agregada exitosamente!");
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        private bool validar()
        {
            if (string.IsNullOrEmpty(tbxDescripcion.Text) || !validarCadena())
            {
                alertAviso("Error!", "Por favor ingrese al menos un caracter");
                return false;
            }
            else
            {
                return true;
            }
        }
        
        private bool validarCadena()
        {
            foreach(var c in tbxDescripcion.Text)
            {
                if (!char.IsWhiteSpace(c))
                {
                    return true;
                }
            }
            return false;
        }

        private void alertAviso(string title, string message)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, title, buttons, MessageBoxIcon.Exclamation);
        }
    }
}
