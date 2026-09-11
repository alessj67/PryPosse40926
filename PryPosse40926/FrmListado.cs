using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryPosse40926
{
    public partial class FrmListado : Form
    {
        public FrmListado()
        {
            InitializeComponent();
        }
        clsArchivoClientes x = new clsArchivoClientes();
        private void btnListar_Click(object sender, EventArgs e)
        {
            x.Listar(dgvGrilla);
            
            lblCant.Text = x.CantClientes().ToString();

            lblTotalD.Text = x.Tdeuda().ToString();
            lblPromD.Text = x.Promedio().ToString();
        }

        private void lblPromD_Click(object sender, EventArgs e)
        {

        }

        private void lblCant_Click(object sender, EventArgs e)
        {

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            x.Reporte();
            MessageBox.Show("Reporte Generado", "nashe", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
