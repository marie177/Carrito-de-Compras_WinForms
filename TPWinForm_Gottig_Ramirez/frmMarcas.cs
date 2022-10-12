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
    public partial class frmMarcas : Form
    {
        private List<Marca> listadoMarcas;
        private MarcaNegocio negocioMarca = new MarcaNegocio();
        public frmMarcas()
        {
            InitializeComponent();
        }
        private void frmMarcas_Load(object sender, EventArgs e)
        {
            updateGrilla();
        }
        private void updateGrilla()
        {
            try
            {
                listadoMarcas = negocioMarca.listar();
                dgvMarcas.DataSource = listadoMarcas;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void filtrar()
        {
            List<Marca> listaFilrada = new List<Marca>();
            string filtro = tbxFiltro.Text;

            if(filtro != null)
            {
                listaFilrada = listadoMarcas.FindAll(m => m.Descripcion.ToUpper().StartsWith(filtro.ToUpper()));
            }
            else
            {
                listaFilrada = listadoMarcas;
            }
            dgvMarcas.DataSource = null;
            dgvMarcas.DataSource = listaFilrada;
        }
        private void tbxFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                filtrar();
            }
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            filtrar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarMarca frmAgregarMarca = new frmAgregarMarca();
            frmAgregarMarca.ShowDialog();
            updateGrilla();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(dgvMarcas.CurrentRow != null)
            {
                Marca marca = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
                frmAgregarMarca frmModificarMarca = new frmAgregarMarca(marca);
                frmModificarMarca.ShowDialog();
                updateGrilla();
            }
            else
            {
                alertAviso("Atencion!", "No ha seleccionado ninguna Marca");
            }
            updateGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(dgvMarcas.CurrentRow != null)
            {
                Marca eliminarMarca = (Marca)dgvMarcas.CurrentRow.DataBoundItem;

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                string mensaje = $"Desea eliminar la Marca: {eliminarMarca.Descripcion}?";
                string title = "Confirmar borrado";

                DialogResult msg = MessageBox.Show(mensaje, title, buttons, MessageBoxIcon.Question);
                if (msg == DialogResult.Yes)
                {
                    try
                    {
                        negocioMarca.EliminarMarca(eliminarMarca);
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
            else
            {
                alertAviso("Atencion!", "No ha seleccionado ninguna Marca");
            }
            updateGrilla();

        }

        private void alertAviso(string title, string message)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, title, buttons, MessageBoxIcon.Exclamation);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
