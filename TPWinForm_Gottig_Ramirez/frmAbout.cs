using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_Gottig_Ramirez
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void btnLaMejor_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/marianella-gottig-93a7a7239/");
        }

        private void btnElMejor_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/emiliano-ramirez-0681b0165/");
        }

        private void btnLaMejor_MouseHover(object sender, EventArgs e)
        {
            btnLaMejor.FlatAppearance.BorderSize = 1;
        }

        private void btnLaMejor_MouseLeave(object sender, EventArgs e)
        {
            btnLaMejor.FlatAppearance.BorderSize = 0;
        }

        private void btnElMejor_MouseLeave(object sender, EventArgs e)
        {
            btnElMejor.FlatAppearance.BorderSize = 0;
        }

        private void btnElMejor_MouseEnter_1(object sender, EventArgs e)
        {
            btnElMejor.FlatAppearance.BorderSize = 2;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRepo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Emi-R/tp-winform-gottig-ramirez");
        }
    }
}
