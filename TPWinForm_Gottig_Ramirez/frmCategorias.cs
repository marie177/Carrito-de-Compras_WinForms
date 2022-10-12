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
    public partial class frmCategorias : Form
    {
        private List<Categoria> listaCategorias;
        private CategoriaNegocio catNegocio = new CategoriaNegocio();
        public frmCategorias()
        {
            InitializeComponent();
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            updateGrilla();
        }

        private void updateGrilla()
        {
            try
            {
                listaCategorias = catNegocio.listar();
                dgvCategorias.DataSource = listaCategorias;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void filtrar()
        {
            List<Categoria> listaFiltrada;
            string filtro = tbxFiltro.Text;

            if (filtro != null)
            {
                listaFiltrada = listaCategorias.FindAll(c => c.Descripcion.ToUpper().StartsWith(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listaCategorias;
            }

            dgvCategorias.DataSource = null;
            dgvCategorias.DataSource = listaFiltrada;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            filtrar();
        }
        private void CheckEnterKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                filtrar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Categoria eliminarCat = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            string mensaje = $"Desea eliminar la Categoria: {eliminarCat.Descripcion}?";
            string title = "Confirmar borrado";

            DialogResult msg = MessageBox.Show(mensaje, title, buttons, MessageBoxIcon.Question);
            if (msg == DialogResult.Yes)
            {
                try
                {
                    catNegocio.EliminarCategoria(eliminarCat);
                    updateGrilla();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
            else
            {
                return;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(dgvCategorias.CurrentRow != null)
            {
                Categoria modificarCat = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
                frmAgregarCategoria frmAgregarArt = new frmAgregarCategoria(modificarCat);
                frmAgregarArt.ShowDialog();
            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;

                string mensaje = $"No ha seleccionado ninguna Categoria";
                string title = "Atencion!";

                MessageBox.Show(mensaje, title, buttons, MessageBoxIcon.Exclamation);
            }
            updateGrilla();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarCategoria frmAgregarArt = new frmAgregarCategoria();
            frmAgregarArt.ShowDialog();
            updateGrilla();
        }
    }
}
